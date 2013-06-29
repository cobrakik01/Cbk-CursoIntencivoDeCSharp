using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Curso.Libros.Util
{
    sealed public class DataSourceFactory
    {
        private static DataSourceFactory dsf;
        private IDbConnection Connection;
        private IDbCommand Command;

        private DataSourceFactory()
        {
            Console.WriteLine("Se creo un objeto de tipo DataSourceFactory");
            this.Connection = new MySqlConnection("DataBase=ado;Data Source=localhost;User Id=root; Password=");
            this.Command = new MySqlCommand();
            this.Command.Connection = this.Connection;
            this.Connection.Open();
        }

        public static DataSourceFactory GetDataSourceFactory()
        {
            if (dsf == null)
            {
                dsf = new DataSourceFactory();
            }
            return dsf;
        }

        public IDbConnection GetConnection()
        {
            return this.Connection;
        }

        public IDbCommand GetCommand()
        {
            return this.Command;
        }

        public static object NewParameter(string nombreParametro, object valor)
        {
            return new MySql.Data.MySqlClient.MySqlParameter(nombreParametro, valor);
        }
    }
}
