using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo14
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> lista = new SortedList<string, string>();
            lista.Add("n1", "Hola");
            lista.Add("n2", "Mundo");
            lista.Add("n3", "p");

            foreach (KeyValuePair<string, string> pair in lista)
            {
                Console.WriteLine("Clave: {0}, Valor: {1}", pair.Key, pair.Value);
            }

            Console.ReadLine();
        }
    }
}
