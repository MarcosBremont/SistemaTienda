using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTienda
{
    public class Conexion
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost; database=SistemaTienda; user=root; password=1234");
        private MySqlConnection con;

      

        public void Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else 
            { 
            
            }
        }

        public void Desconectar()
        {

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            { 
            
            }

        }

        public MySqlConnection GetCon()
        {
            con = connection;
            return con;
        }
    }

}
