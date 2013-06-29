using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libros.Model;
using Curso.Libros.Controller;

namespace Curso.Libros.Core
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibrosController controlador = new LibrosController();

            LibroModel libro = new LibroModel();
            libro.Titulo = "C#";
            libro.Autor = "Eutiquio";
            libro.Editorial = "ITMA";
            libro.Descripcion = "nada";

            controlador.Agregar(libro);
            Console.ReadLine();
        }
    }
}
