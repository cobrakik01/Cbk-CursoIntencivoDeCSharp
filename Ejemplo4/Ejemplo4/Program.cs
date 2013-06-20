using Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo4.Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona();
            Console.Write("Escribe tu nombre: ");
            per.Nombre = Console.ReadLine();

            Console.Write("Escribe la cuota: ");
            per.Couta = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Presiona enter para continuar...");
            Console.ReadLine();
        }
    }
}
