using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Paloma p = new Paloma();
            Cartero c = new Cartero();
            Email e = new Email();

            Mensajeria[] mensajes = new Mensajeria[3];
            mensajes[0] = p;
            mensajes[1] = c;
            mensajes[2] = e;

            foreach(Mensajeria m in mensajes){
                Console.WriteLine(m);
            }
            //Email E = new Email();
            //E.prueba("aqui toy");
            Console.ReadLine();

        }
    }
}
