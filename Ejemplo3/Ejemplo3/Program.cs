using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string x;
            string y;
            Console.Write("escribe un numero");
            x = Console.ReadLine();
            Console.Write("escribe otro numero");
            y = Console.ReadLine();

          // a=Convert.ToInt32(x); se utiliza en cls
            a=int.Parse(x);
            b=int.Parse(y);
            c = a + b;

            System.Console.WriteLine("las suma es "+ c);
            Console.ReadLine();
        }

    }
}
