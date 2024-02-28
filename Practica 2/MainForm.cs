using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Antlr4.Runtime;
using antlr;
using Practica_SICXE.antlr;

namespace Practica_SICXE
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        //lista de errores
        List<string> errores = new List<string>();
        //tabla de simbolos
        List<string> TABSIM = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CargarArchivo_Click(object sender, EventArgs e)
        {
            //modal para seleccionar un archivo
            OpenFileDialog modal = new OpenFileDialog();
            //definimos la extension del archivo
            modal.DefaultExt = "xe";
            //filtrar archivos con la extension
            modal.Filter = "Elige un archivo .xe | *.xe";
            //si se elige un archivo de la extension
            if(modal.ShowDialog() == DialogResult.OK)
            {
                //colocar el nombre del archivo en la barra de estado
                archivo.Text = modal.FileName;
                //mostrar el contenido del archivo en el textBox enumerado
                //lee linea porlinea 
                codigo.RichTextBox.Text = File.ReadAllText(modal.FileName);
            }

        }

        private void Compilar_Click(object sender, EventArgs e)
        {
            //se evalua que se tenga cargado un archivo
            if (codigo.RichTextBox.Text != "")
            {
                //limpiar listas
                errores.Clear();
                TABSIM.Clear();
                //obtiene el codigo de la caja de texto multilinea
                //encuentra los saltos de linea y los reemplaza por espacios en blanco
                //.split los separa y se combierte en lista
                List<string> lineas = codigo.RichTextBox.Text.Replace("\r", " ").Split('\n').ToList();

                //interpretar la 1era linea
                InterpretaLinea(lineas[0], 0, "start");
                for (int linea = 1; linea < lineas.Count - 1; linea++)
                    InterpretaLinea(lineas[linea], linea, "body");
                InterpretaLinea(lineas.Last(), lineas.Count, "end");

                //si hubo al menos un error 
                if (errores.Count > 0)
                {
                    //pone el numero de errores
                    NumErrores.Text = errores.Count.ToString();
                    //guarda el archivo en la carpeta 
                    guardaArchivo(Path.GetFileNameWithoutExtension(archivo.Text), "err", errores);
                }
            }
            else MessageBox.Show("Cargue un archivo");
        }

        //tipo indica si es inicio, proposicion o final 
        private void InterpretaLinea(string linea, int numero, string tipo)
        {
            //se definen analizadores
            //se inicializa el analizador lexico con la linea que se le paso por parametro 
            //se le concatena un salto de linea para que lo entienda la gramatica
            SICXELexer analizadorLexico = new SICXELexer(new AntlrInputStream(linea+Environment.NewLine));
            //se inicializa el analizador de tokens
            CommonTokenStream tokens = new CommonTokenStream(analizadorLexico);
            //se inicializa el parser o interpretador
            SICXEParser parser = new SICXEParser(tokens);
            //le dice al interpretador como manejar los errores
            parser.AddErrorListener(new SICXEParserErrorListener());
            try
            {
                //se evaluan los 3 casos, start, body o end
                switch (tipo)
                {
                    case "start":
                        //evalua la sintaxis de la linea de inicio
                        SICXEParser.InicioContext ctxInicio = parser.inicio();
                        //valida que no este repetida la etiqueta
                        ValidaId(ctxInicio.Start, analizadorLexico.Vocabulary);
                        break;
                    case "body":
                        //evalua la sintaxis de la linea de proposicion
                        SICXEParser.ProposicionContext ctxProposicion = parser.proposicion();
                        //valida que no este repetida la etiqueta
                        ValidaId(ctxProposicion.Start, analizadorLexico.Vocabulary);
                        break;
                    case "end": parser.fin(); break;
                }

            } catch (Exception ex)
            {
                //agrega los errores a la lista de errores
                errores.Add("[" + (numero + 1) + "] --> " + ex.Message);
            }
        }
        //valida que no este repetida la etiqueta
        private void ValidaId(IToken token, IVocabulary vocabulary)
        {
            //si con base en el vocabulario obtenemos el tipo de token, si es de tipo id
            if(vocabulary.GetSymbolicName(token.Type) == "ID")
            {
                //evalua si la etiqueta no esta en la tabla de simbolos
                if(!TABSIM.Contains(token.Text)) 
                    //agrega la etiqueta a la tabla de simbolos
                    TABSIM.Add(token.Text);
                else
                    //si el simbolo esta duplicado arroja un error
                    throw new ArgumentException("simbolo duplicado '"+token.Text+"'");
            }
        }

        //muestra los errores 
        private void MostrarErrores_Click(object sender, EventArgs e)
        {
            new Errores(errores).ShowDialog();
        }

        //guarda el archivo de errores 
         public void guardaArchivo(String nombre, String extension, List<String> texto)
        {
            //crea un nuevo archivo para escritura
            FileStream fStream = new FileStream(
                //indica donde lo creara con que nombre y con que extension 
                AppDomain.CurrentDomain.BaseDirectory + nombre + '.' + extension, 
                FileMode.Create, FileAccess.Write
            );
            //se escribe dentro del archivo
            StreamWriter m_WriterParameter = new StreamWriter(fStream);
            //llamadas para escribir en el archivo
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(String.Join("\n", texto));
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }
    }
}
