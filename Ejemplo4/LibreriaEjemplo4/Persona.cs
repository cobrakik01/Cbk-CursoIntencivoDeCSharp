using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Persona
    {
        private string _Nombre;
        private decimal _Cuota;

        public string Nombre
        {
            set
            {
                this._Nombre = value;
            }
            get
            {
                return this._Nombre;
            }
        }

        public decimal Couta
        {
            set
            {
                if (value > 0)
                {
                    this._Cuota = value;
                }
                else
                {
                    Console.WriteLine("Se esta haciendo una operacion invalida!!!");
                }
            }
            get
            {
                return this._Cuota;
            }
        }
    }

}
