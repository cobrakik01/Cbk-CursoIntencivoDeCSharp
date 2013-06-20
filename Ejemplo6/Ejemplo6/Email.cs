using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo6
{
    class Email : Cartero
    {
        public override void prueba(string b)
        {
            base.prueba(b);
            Console.WriteLine(b+ " desde la clase Email");
        }

        public override string ToString()
        {
            return "Mensaje desde Email";
        }
       
    }
}
