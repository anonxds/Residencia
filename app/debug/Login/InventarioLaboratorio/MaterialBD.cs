using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventarioLaboratorio
{
    public class MaterialBD
    {
        public static int AgregarMaterial(Material pMaterial)
        {
            int retorno = 0;
            using (SqlConnection Conn = ConexionBD.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Material(Nombre, Tipo, Capacidad, Estado, Laboratorio, Observaciones) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    pMaterial.Nombre, pMaterial.Tipo, pMaterial.Capacidad, pMaterial.Estado, pMaterial.Laboratorio, pMaterial.Observacion), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            //Como se creo un metodo static debe retornar algo o marcara error
            return retorno;
        }

        public static List<Material> BuscarMaterial(String pTipo, String pLaboratorio)
        {
            List<Material> ListaMat = new List<Material>();
            using (SqlConnection ConBsq = ConexionBD.ObtenerConexion())
            {
                SqlCommand ComBsq = new SqlCommand(string.Format("Select Id, Nombre, Tipo, Capacidad, Estado, Laboratorio, Observaciones from Material where Tipo like '%{0}%' and  Laboratorio like '%{1}%' ", pTipo, pLaboratorio), ConBsq);
                SqlDataReader lector = ComBsq.ExecuteReader();

                while (lector.Read())
                {
                    Material pMaterial = new Material();
                    pMaterial.Id = lector.GetInt64(0);
                    pMaterial.Nombre = lector.GetString(1);
                    pMaterial.Tipo = lector.GetString(2);
                    pMaterial.Capacidad = lector.GetString(3);
                    pMaterial.Estado = lector.GetString(4); ;
                    pMaterial.Laboratorio = lector.GetString(5);
                    pMaterial.Observacion = lector.GetString(6);

                    ListaMat.Add(pMaterial);
                }
                ConBsq.Close();
                return ListaMat;
            }
        }
    }
}
