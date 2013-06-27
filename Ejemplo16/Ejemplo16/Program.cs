using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ejemplo16
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertarRegistro();
            //SeleccionarRegistro();


            int op = 0;
            do
            {

                Console.Write("1-Insertar" + "\n 2-Elimninar" + "\n 3-Actualizar" + "\n 4-Seleccionar" + "\n 5-Salir");
                Console.Write("Elige una opción");
                string str = Console.ReadLine();
                op = int.Parse(str);


                switch (op)
                {

                    case 1:
                        PedirDatos();
                        Console.Clear();
                        break;
                    case 2:
                        Eliminar();
                        Console.Clear();
                        break;
                    case 3:
                        break;
                    case 4:
                        MostrarTodos();

                        break;
                    case 5:
                        break;
                }

            } while (op != 5);
        }

        private static void PedirDatos()
        {

            Console.Write("Ingresa el título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ingresa el autor: ");
            string autor = Console.ReadLine();
            Console.Write("Ingresa la editorial: ");
            string editorial = Console.ReadLine();
            Console.Write("Ingresa la descripción: ");
            string descripcion = Console.ReadLine();

            Insertar(titulo, autor, editorial, descripcion);
        }

        private static void Insertar(string titulo, string autor, string editorial, string descripcion)
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Database=ado;Data Source=localhost;User Id=root;Password=";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into libros values('" + titulo + "','" + autor + "','" + editorial + "','" + descripcion + "');";

            con.Open();
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();

        }

        private static void Eliminar()
        {

            Console.Write("Ingresa el título del libro a eliminar");
            string titulo = Console.ReadLine();

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Database=ado;Data Source=localhost;User Id=root;Password=";


            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from libros where titulo = '" + titulo + "';";

            con.Open();
            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Dispose();
            con.Close();

        }


        private static void MostrarTodos()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Database=ado;Data Source=localhost;User Id=root;Password=";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from libros";

            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                string titulo = reader.GetString(0);
                string autor = reader.GetString(1);
                string editorial = reader.GetString(2);
                string descripcion = reader.GetString(3);

                Console.WriteLine(titulo + "-" + autor + "-" + editorial + "-" + descripcion);


            }

            cmd.Dispose();

            con.Dispose();
            con.Close();


        }

        private static void Actualizar()
        {

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Database=ado;Data Source=localhost;User Id=root;Password=";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;



        }

        /* private static void SeleccionarRegistro()
         {
             MySqlConnection cn = new MySqlConnection();
             cn.ConnectionString = "Database=ado;Data Source=localhost;User Id=root;Password=";

             MySqlCommand cmd = new MySqlCommand();
             cmd.Connection = cn;
             cmd.CommandText = "SELECT * FROM libros;";

             cn.Open();
             MySqlDataReader reader = cmd.ExecuteReader();

             while (reader.Read())
             {
                 string titulo = reader.GetString(0);
                 string autor = reader.GetString(1);
                 string editorial = reader.GetString(2);
                 string descripcion = reader.GetString(3);
                 Console.WriteLine(titulo + " - " + autor + " - " + editorial + " - " + descripcion);
             }
             Console.ReadLine();

             reader.Dispose();
             reader.Close();
             cn.Dispose();
             cn.Close();
         }

         private static void InsertarRegistro()
         {
             MySqlConnection cn = new MySqlConnection();
             cn.ConnectionString = "Database=ado;Data Source=localhost;User Id=root;Password=";

             MySqlCommand sqlCommand = new MySqlCommand();
             sqlCommand.Connection = cn;
             sqlCommand.CommandText = "INSERT INTO libros VALUES('Java','Samuel','ITMA','Sin descripcion')";

             cn.Open();

             int n = sqlCommand.ExecuteNonQuery();

             cn.Dispose();
             cn.Close();

             Console.WriteLine(n);
             Console.ReadLine();
         }*/
    }
}
