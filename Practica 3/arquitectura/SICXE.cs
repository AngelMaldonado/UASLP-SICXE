using antlr;
using Antlr4.Runtime;
using PracticaSICXE.antlr;
using PracticaSICXE.arquitectura;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSICXE.arquitectura
{
    internal class SICXE
    {
        public struct ResultadoParse
        {
            // numero de linea
            public int linea;
            // unidad de memoria de la linea
            public uint num;
            // tipo de instruccion
            public string tipo;
            // etiqueta
            public string etiqueta;
            // instruccion o directiva
            public string instruccion;
            // operando
            public string operando;
            // indica si hubo error
            public bool error;
            // simbolo duplicado
            public bool simdupl;
            // token que causo el error
            public string msgerror;
            // modo
            public string modo;
            // indica si es formato 2
            public bool formato2;
            // indica si es formato 4
            public bool formato4;

            public ResultadoParse(int numero)
            {
                linea = numero;
                num = 0;
                etiqueta = "";
                tipo = "";
                instruccion = "";
                operando = "";
                error = false;
                simdupl = false;
                msgerror = "";
                modo = "";
                formato2 = false;
                formato4 = false;
            }
        }

        public struct Simbolo
        {
            // etiqueta
            public string etiq;
            // direccion
            public uint dir;

            public Simbolo(string etiq, uint dir = 0)
            {
                this.etiq = etiq;
                this.dir = dir;
            }
        }

        //lista de errores
        public List<string> Errores { get; }

        //tabla de simbolos
        public Dictionary<string, uint?> TABSIM { get; }

        //[nuevo]lista de contadores (PC)
        public List<long> CP { get; }

        //[nuevo]lista con la interpretacion de todas las líneas
        public List<ResultadoParse> ResultadosParse { get; }

        public uint Longitud { get; set; }

        public SICXE()
        {
            Errores = new List<string>();
            TABSIM = new Dictionary<string, uint?>();
            ResultadosParse = new List<ResultadoParse>();
            CP = new List<long>();
        }

        public void InterpretaCodigo(Programa programa)
        {
            //limpiar listas
            Errores.Clear();
            TABSIM.Clear();

            //interpretar la 1era linea
            InterpretaLinea(programa.Lineas[0], 0, "start");

            //interpreta las lineas "body"
            for (int linea = 1; linea < programa.Lineas.Count - 1; linea++)
                InterpretaLinea(programa.Lineas[linea], linea, "body");

            //interpreta el final
            InterpretaLinea(programa.Lineas.Last(), programa.Lineas.Count, "end");

            //calcula la longitud
            Longitud = (uint)CP.Last() - (uint)CP.First();

            //limpia la tabla de simbolos de valores nulos
            if (TABSIM.ContainsValue(null))
                //[nuevo]
                for (int simbolo = 0; simbolo < TABSIM.Count; simbolo++)
                    if (TABSIM.Values.ElementAt(simbolo) == null)
                        TABSIM.Remove(TABSIM.Keys.ElementAt(simbolo));

            //imprime el archivo
            List<string> contenido = new List<string>();
            for (int res = 0; res < ResultadosParse.Count; res++)
            {
                var resultado = ResultadosParse[res];
                contenido.Add(
                    resultado.linea + " " +
                    resultado.num + " " +
                    resultado.etiqueta + " " +
                    resultado.instruccion + " " +
                    resultado.instruccion + " " +
                    resultado.operando + " " +
                    (resultado.error || resultado.simdupl ? resultado.msgerror : resultado.modo)
                );
            }

            GuardaArchivo(Path.GetFileNameWithoutExtension(programa.Archivo), "loc", contenido);

            contenido.Clear();
            foreach (var sim in TABSIM)
                contenido.Add(sim.Key + " " + sim.Value?.ToString("X4"));

            contenido.Add(">> longitud: " + Longitud.ToString("X4"));

            GuardaArchivo(Path.GetFileNameWithoutExtension(programa.Archivo), "sim", contenido);

            if (Errores.Count > 0)
                //guarda el archivo de errores
                GuardaArchivo(Path.GetFileNameWithoutExtension(programa.Archivo), "err", Errores);
        }

        //tipo indica si es inicio, proposicion o final 
        private void InterpretaLinea(string linea, int numero, string tipo)
        {
            //resultado de la interpretación
            ResultadoParse resultado = new ResultadoParse(numero);

            //se definen analizadores
            //se inicializa el analizador lexico con la linea que se le paso por parametro 
            //se le concatena un salto de linea para que lo entienda la gramatica
            SICXELexer analizadorLexico = new SICXELexer(new AntlrInputStream(linea + Environment.NewLine));
            //se inicializa el analizador de tokens
            CommonTokenStream tokens = new CommonTokenStream(analizadorLexico);
            //se inicializa el parser o interpretador
            SICXEParser parser = new SICXEParser(tokens);
            //le dice al interpretador como manejar los errores
            parser.AddErrorListener(new SICXEParserErrorListener());

            //[nuevo]analiza sintácticamente
            try
            {
                //se evaluan los 3 casos, start, body o end
                switch (tipo)
                {
                    case "start":
                        parser.inicio();
                        break;
                    //evalua la sintaxis de la linea de proposicion
                    case "body":
                        parser.proposicion();
                        break;
                    case "end":
                        parser.fin();
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                //agrega los errores a la lista de errores
                Errores.Add("[" + (numero + 1) + "] --> " + ex.Message);
                //[nuevo]establece bandera de error en resultado en verdadero
                resultado.error = true;
                //[nuevo]guarda el token que causo el error
                resultado.msgerror = ex.Message;
            }

            //[nuevo]analiza token por token
            AnalizaTokens(tokens.GetTokens(), parser.Vocabulary, ref resultado);
            //[nuevo]incrementa CP con base en el resultado
            IncrementaCP(ref resultado);
            //[nuevo]grega el resultado de la interpretación a la lista
            ResultadosParse.Add(resultado);
        }

        private void IncrementaCP(ref ResultadoParse resultado)
        {
            //[nuevo]incrementa el contador si no hubo ningun error en la linea
            if (!resultado.error)
                switch (resultado.tipo)
                {
                    case "OPF1":
                        resultado.num = (uint)CP.Last();
                        CP.Add(CP.Last() + 1);
                        break;
                    case "OPF2":
                        resultado.num = (uint)CP.Last();
                        CP.Add(CP.Last() + 2);
                        break;
                    case "OPF3":
                        resultado.num = (uint)CP.Last();
                        CP.Add(CP.Last() + 3);
                        break;
                    case "OPF4":
                        resultado.num = (uint)CP.Last();
                        CP.Add(CP.Last() + 4);
                        break;
                    case "BYTE":
                    case "RESB":
                        CP.Add(CP.Last() + resultado.num);
                        resultado.num = (uint)CP.Last() - resultado.num;
                        break;
                    case "RESW":
                        CP.Add(CP.Last() + resultado.num * 3);
                        resultado.num = (uint)CP.Last() - resultado.num * 3;
                        break;
                    case "RSUB":
                    case "WORD":
                        resultado.num = (uint)CP.Last();
                        CP.Add(CP.Last() + 3);
                        break;
                    case "BASE":
                        resultado.num = (uint)CP.Last();
                        CP.Add((uint)CP.Last());
                        break;
                    case "END":
                        resultado.num = (uint)CP.Last();
                        break;
                    case "START":
                        CP.Add(resultado.num);
                        CP.Add(resultado.num);
                        break;
                }
            else
            {
                resultado.num = (uint)CP.Last();
                CP.Add(CP.Last());
            }

            string etiqueta = resultado.etiqueta;
            string operando = resultado.operando;
            string key = TABSIM.Keys.FirstOrDefault(k => k == etiqueta || k == operando);

            if (!resultado.simdupl && !resultado.error && key != null && TABSIM[key] == null)
                TABSIM[key] = resultado.num;
            else if (key != null)
                TABSIM.Remove(etiqueta);

        }

        private void AnalizaTokens(IList<IToken> tokens, IVocabulary vocabulario, ref ResultadoParse resultado)
        {
            //[nuevo]analiza token por token (palabra por palabra)
            foreach (IToken token in tokens)
            {

                switch (vocabulario.GetDisplayName(token.Type))
                {
                    case "'START'":
                        resultado.tipo = "START";
                        resultado.instruccion += token.Text;
                        break;
                    case "'END'":
                        resultado.tipo = "END";
                        resultado.instruccion = token.Text;
                        break;
                    case "OPF1":
                        resultado.tipo = "OPF1";
                        resultado.instruccion += token.Text;
                        break;
                    case "OPF2":
                        resultado.tipo = "OPF2";
                        resultado.instruccion += token.Text;
                        resultado.formato2 = true;

                        //[nuevo]extrae el/los operandos
                        int start = tokens.IndexOf(token) + 1;
                        List<IToken> subListTokens = tokens.ToList().GetRange(start, tokens.Count() - start);
                        string operando = "";
                        foreach (var item in subListTokens)
                            operando += (item.Text.Trim() == "\n" || item.Text.Trim() == "<EOF>") ? "" : item.Text.Trim();
                        resultado.operando += operando;
                        break;
                    case "OPF3":
                        //[nuevo]condicion para OPF4
                        resultado.tipo = token.Text == "RSUB" ? "RSUB" : resultado.formato4 ? "OPF4" : "OPF3";
                        resultado.instruccion += token.Text;
                        resultado.modo = "simple";
                        break;
                    case "'+'":
                        resultado.formato4 = true;
                        resultado.instruccion += token.Text;
                        break;
                    case "INDEX":
                        if (!resultado.formato2)
                            resultado.operando += token.Text;
                        break;
                    case "TIPODIRECTIVA":
                        resultado.tipo = resultado.instruccion = token.Text;
                        break;
                    case "OPDIRECTIVA":
                        resultado.operando += token.Text;
                        resultado.num = (uint)token.Text.Length - 3;
                        if (token.Text.First() == 'X')
                            resultado.num = (uint)Math.Ceiling((double)resultado.num / 2);
                        break;
                    case "NUM":
                        if (!resultado.formato2)
                        {
                            resultado.operando += token.Text;
                            if (token.Text.Last() == 'H' || token.Text.Last() == 'h')
                                uint.TryParse(token.Text.Remove(token.Text.Count() - 1), NumberStyles.HexNumber, CultureInfo.CurrentCulture, out resultado.num);
                            else
                                uint.TryParse(token.Text, out resultado.num);
                        }
                        break;
                    case "'#'":
                        resultado.operando += token.Text;
                        resultado.modo = "inmediato";
                        break;
                    case "'@'":
                        resultado.operando += token.Text;
                        resultado.modo = "indirecto";
                        break;
                    case "ID":
                        try
                        {
                            if (resultado.error && resultado.instruccion == "")
                                resultado.instruccion += token.Text;
                            else if (resultado.instruccion.Length > 0)
                            {
                                resultado.operando += token.Text;
                                if (resultado.operando[0] != '#' && resultado.operando[0] != '@')
                                    ValidaSimbolo(token.Text, true);
                            }
                            else
                            {
                                resultado.etiqueta += token.Text;
                                ValidaSimbolo(token.Text);
                            }
                        }
                        catch (Exception ex)
                        {
                            //agrega los errores a la lista de errores
                            Errores.Add("[" + (resultado.linea + 1) + "] --> " + ex.Message);
                            resultado.simdupl = true;
                            resultado.msgerror = ex.Message;
                        }
                        break;
                }
            }
        }

        //valida que no este repetida la etiqueta
        //[nuevo]se valida la etiqueta o operando segun corresponda
        private void ValidaSimbolo(string token, bool operando = false)
        {
            //evalua si la etiqueta no esta en los resultados ya interpretados
            if (!operando && !ResultadosParse.Any(r => r.etiqueta == token))
                if (!TABSIM.ContainsKey(token))
                    TABSIM.Add(token, null);
                else if (operando && !ResultadosParse.Any(r => r.operando == token))
                    if (!TABSIM.ContainsKey(token))
                        TABSIM.Add(token, null);
                    else
                        //si el simbolo esta duplicado arroja un error
                        throw new ArgumentException("simbolo duplicado '" + token + "'", token);
        }

        //guarda el archivo de errores 
        public void GuardaArchivo(String nombre, String extension, List<String> texto)
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
