using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace InventarioLaboratorio
{
    public class ConexionBD
    {
       
        public static SqlConnection ObtenerConexion()
        {
            //SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-CO02HDD\\SQLEXPRESS; Initial Catalog=LaboratorioBD; Integrated Security=True");
            SqlConnection Conn = new SqlConnection("Server=tcp:karinaitt.database.windows.net,1433;Initial Catalog=Laboratorio;Persist Security Info=False;User ID=karina;Password=Jona6812;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            Conn.Open();

            //Como se creo un metodo static debe retornar algo. Se retorna Conn
            return Conn;
        }
    }
}
