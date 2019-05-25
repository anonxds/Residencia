using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace InventarioLaboratorio
{
    class Sql
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public void setcon()
        {
            con = new SqlConnection("Data Source=DESKTOP-CO02HDD\\SQLEXPRESS; Initial Catalog=LaboratorioBD; Integrated Security=True");  
        }

        public void Exe(string query)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
