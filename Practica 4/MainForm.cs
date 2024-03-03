using System;
using System.Windows.Forms;
using System.IO;
using PracticaSICXE.arquitectura;
using System.Drawing;

namespace PracticaSICXE
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        // objeto que representa la arquitectura SICXE
        arquitectura.SICXE Arquitectura = new arquitectura.SICXE();

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
            if (modal.ShowDialog() == DialogResult.OK)
            {
                //colocar el nombre del archivo en la barra de estado
                archivo.Text = modal.FileName;
                //mostrar el contenido del archivo en el textBox enumerado
                codigo.RichTextBox.Text = File.ReadAllText(modal.FileName);
            }

        }

        private void Compilar_Click(object sender, EventArgs e)
        {
            //se evalua que se tenga cargado un archivo
            if (codigo.RichTextBox.Text != "")
            {
                //guarda los cambios
                File.WriteAllText(archivo.Text, codigo.RichTextBox.Text);

                // Interpreta el código
                Arquitectura.InterpretaCodigo(new Programa(archivo.Text));

                ActualizaTablasSICXE();

                //si hubo al menos un error 
                if (Arquitectura.Errores.Count > 0)
                    //pone el numero de errores
                    NumErrores.Text = Arquitectura.Errores.Count.ToString();
                else NumErrores.Text = "0";
            }
            else MessageBox.Show("Cargue un archivo");
        }

        //muestra el resultado de la interpretación en las tablas SICXE
        private void ActualizaTablasSICXE()
        {
            //si ya hay almenos un cp
            if (Arquitectura.ResultadosParse.Count > 0)
            {
                CONTLOCDataGridView.Rows.Clear();
                TABSIMDataGridView.Rows.Clear();

                foreach (var resultado in Arquitectura.ResultadosParse)
                {
                    CONTLOCDataGridView.Rows.Add(new object[]
                    {
                        resultado.linea + 1,
                        resultado.cp.ToString("X4"),
                        resultado.etiqueta,
                        resultado.instruccion,
                        resultado.operando,
                        resultado.modo,
                        resultado.msgerror
                    });
                    if (resultado.error)
                        CONTLOCDataGridView.Rows[CONTLOCDataGridView.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                }

                foreach (var simbolo in Arquitectura.TABSIM)
                    TABSIMDataGridView.Rows.Add(new object[]
                    {
                        simbolo.Key,
                        simbolo.Value?.ToString("X4")
                    });

                longitudPrograma.Text = "Longitud del programa: " + Arquitectura.Longitud.ToString("X4");
            }
        }

        //muestra los errores 
        private void MostrarErrores_Click(object sender, EventArgs e)
        {
            new Errores(Arquitectura.Errores).ShowDialog();
        }
    }
}
