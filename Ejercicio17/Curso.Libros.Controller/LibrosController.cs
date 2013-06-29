using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libros.Dao;
using Curso.Libros.Model;

namespace Curso.Libros.Controller
{
    public class LibrosController
    {
        public void Agregar(LibroModel libro){
            LibrosDao dao = new LibrosMySql();
            dao.Agregar(libro);
        }
    }
}
