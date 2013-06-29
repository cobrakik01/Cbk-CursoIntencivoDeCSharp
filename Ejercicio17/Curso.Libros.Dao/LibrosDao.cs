using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libros.Model;

namespace Curso.Libros.Dao
{
    public interface LibrosDao
    {
        LibroModel BuscarPorTitulo(string titulo);
        int Agregar(LibroModel libro);
        int Borrar(string titulo);
        int Actualizar(string titulo, LibroModel nuevoLibro);
        List<LibroModel> BuscarPorAutor(string autor);
        List<LibroModel> BuscarPorEditorial(string autor);
    }
}
