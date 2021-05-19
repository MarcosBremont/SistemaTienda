using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTienda
{
    public class Conexion
    {
        MySqlConnection con = new MySqlConnection("Server=localhost; database=SistemaTienda; user=root; password=1234");
        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
