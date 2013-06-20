using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo6
{
    class Cartero : Mensajeria
    {
        public override string ToString()
        {
            return "mensaje desde cartero";

        }

        public virtual void prueba(string b) {
            Console.WriteLine(b + " desde la clase cartero");
        }
    }
}
