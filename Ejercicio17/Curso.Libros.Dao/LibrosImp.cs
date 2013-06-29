using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curso.Libros.Model;
using Curso.Libros.Util;

namespace Curso.Libros.Dao
{
    public abstract class LibrosImp : LibrosDao
    {

        public abstract string BuscarPorTituloSql();
        public LibroModel BuscarPorTitulo(string titulo)
        {
            LibroModel lib = null;
            return lib;
        }

        public abstract string AgregarSql();
        public int Agregar(LibroModel libro)
        {
            int filasAfectadas = 0;
            DataSourceFactory dsf = DataSourceFactory.GetDataSourceFactory();

            dsf.GetCommand().CommandText = AgregarSql();
            dsf.GetCommand().Parameters.Add(DataSourceFactory.NewParameter("titulo", libro.Titulo));
            dsf.GetCommand().Parameters.Add(DataSourceFactory.NewParameter("autor", libro.Autor));
            dsf.GetCommand().Parameters.Add(DataSourceFactory.NewParameter("editorial", libro.Editorial));
            dsf.GetCommand().Parameters.Add(DataSourceFactory.NewParameter("descripcion", libro.Descripcion));

            filasAfectadas = dsf.GetCommand().ExecuteNonQuery();
            return filasAfectadas;
        }

        public abstract string BorrarSql();
        public int Borrar(string titulo)
        {
            throw new NotImplementedException();
        }

        public abstract string ActualizarSql();
        public int Actualizar(string titulo, LibroModel nuevoLibro)
        {
            throw new NotImplementedException();
        }

        public abstract string BuscarPorAutorSql();
        public List<LibroModel> BuscarPorAutor(string autor)
        {
            throw new NotImplementedException();
        }

        public abstract string BuscarPorEditorialSql();
        public List<LibroModel> BuscarPorEditorial(string autor)
        {
            throw new NotImplementedException();
        }
    }
}
