using antlr;
using Antlr4.Runtime;
using PracticaSICXE.antlr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSICXE.arquitectura
{
    internal class Programa
    {
        //[nuevo]lista con las lineas del codigo
        public List<string> Lineas { get; }

        //[nuevo]cadena de texto que tiene todo el código (con saltos de línea)
        public string Codigo { get; }
        public string Archivo { get; }

        public Programa(string archivo)
        {
            Archivo = archivo;
            //lee linea por linea 
            Codigo = File.ReadAllText(Archivo);
            //encuentra los saltos de linea y los reemplaza por espacios en blanco
            //.split los separa y se combierte en lista
            Lineas = Codigo.Replace("\r", " ").Split('\n').ToList();
        }
    }
}
