using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Libros.Dao
{
    public class LibrosMySql : LibrosImp
    {
        public override string BuscarPorTituloSql()
        {
            throw new NotImplementedException();
        }

        public override string AgregarSql()
        {
            return "INSERT INTO libros values(@titulo, @autor, @editorial, @descripcion)";
        }

        public override string BorrarSql()
        {
            throw new NotImplementedException();
        }

        public override string ActualizarSql()
        {
            throw new NotImplementedException();
        }

        public override string BuscarPorAutorSql()
        {
            throw new NotImplementedException();
        }

        public override string BuscarPorEditorialSql()
        {
            throw new NotImplementedException();
        }
    }
}
