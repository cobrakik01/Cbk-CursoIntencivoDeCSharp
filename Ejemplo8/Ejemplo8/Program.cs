using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejemplo8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nomArchivo = @"C:\Users\cobrakik\Documents\mi archivo.txt";

            File.WriteAllText(nomArchivo, "Hola mundo");
            string contenido = File.ReadAllText(nomArchivo);
            
            /*
            string str = "primer palabra | segunda palabra | tercer palabra";
            string []aux = str.Split('|');
            */

            Console.WriteLine(contenido);
            Console.ReadLine();

        }
    }
}
