using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSICXE.antlr
{
    //clase que maneja los errores
    //extiende de la clase que maneja los errores por defecto en antlr
    internal class SICXEParserErrorListener : BaseErrorListener
    {
        string[] opf1 = { "FIX", "FLOAT", "HIO", "NORM", "SIO", "TIO" };
        string[] opf2 = { "ADDR", "CLEAR", "COMPR", "DIVR", "MULR", "RMO", "SHIFTL", "SHIFTR", "SUBR", "SVC", "TIXR" };
        string[] opf3 = { "ADD", "ADDF", "AND", "COMP", "COMPF", "DIV", "DIVF", "J", "JEQ", "JGT", "JLT", "JSUB", "LDA", "LDB", "LDCH", "LDF", "LDL", "LDS", "LDT", "LDX", "LPS", "MUL", "MULF", "OR", "RD", "RSUB", "SSK", "STA", "STB", "STCH", "STF", "STI", "STL", "STS", "STSW", "STT", "STX", "SUB", "SUBF", "TD", "TIX", "WD" };
        string[] op = { "FIX", "FLOAT", "HIO", "NORM", "SIO", "TIO", "ADDR", "CLEAR", "COMPR", "DIVR", "MULR", "RMO", "SHIFTL", "SHIFTR", "SUBR", "SVC", "TIXR", "ADD", "ADDF", "AND", "COMP", "COMPF", "DIV", "DIVF", "J", "JEQ", "JGT", "JLT", "JSUB", "LDA", "LDB", "LDCH", "LDF", "LDL", "LDS", "LDT", "LDX", "LPS", "MUL", "MULF", "OR", "RD", "RSUB", "SSK", "STA", "STB", "STCH", "STF", "STI", "STL", "STS", "STSW", "STT", "STX", "SUB", "SUBF", "TD", "TIX", "WD" };
        string[] directiva = { "BYTE", "WORD", "RESB", "RESW" , "BASE" };

        //funcion que usa antlr, se pone para manejar los errores de manera manual
        public override void SyntaxError([NotNull] IRecognizer recognizer, [Nullable] IToken offendingSymbol, int line, int charPositionInLine, [NotNull] string msg, [Nullable] RecognitionException e)
        {
            //hace una lista de cadenas con los tokens de la linea en la que paso el error
            var input = offendingSymbol.InputStream.ToString().Split().ToList().Where(s => s != "").ToList();

            //valida si el 1er o 2do token es una direccion o una directiva
            //Si la instruccion o directiva si existe, entonces es error de sintaxis
            if (op.ToList().Contains(input[0]) || directiva.ToList().Contains(input[0]) ||
                op.ToList().Contains(input[1]) || directiva.ToList().Contains(input[1]))
                //arroja el error de sintaxis junto con el token que causo el error
                throw new ArgumentException("error de sintaxis cerca del token '" + offendingSymbol.Text + "'");
            else
                //arroja el error de que no existe la instruccion o directiva
                throw new ArgumentException("en '" + string.Join(" ", input) + "' la instruccion no existe");
        }
    }
}
