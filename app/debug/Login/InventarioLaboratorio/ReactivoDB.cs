using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventarioLaboratorio
{
    public class ReactivoDB
    {
        public static int AgregarReactivo(Reactivo pReactivo)
        {
            int retorno = 0;
            using (SqlConnection Conn = ConexionBD.ObtenerConexion()) //Hace una conexion con la base de datos
            {
                //Aqui se poene las instrucciones de SQL para la insecion de datos
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Reactivo(Nombre, Numero, Clasificacion, Laboratorio, Caducidad, Catalogo, Unidad, Observaciones) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                                                                    pReactivo.Nombre, pReactivo.Numero, pReactivo.Clasificacion, pReactivo.Laboratorio, pReactivo.Caducidad, pReactivo.Catalogo, pReactivo.Unidad, pReactivo.Observacion), Conn);
                retorno = Comando.ExecuteNonQuery();
            }
            //Como se creo un metodo static debe retornar algo o marcara error
            return retorno;
        }

       public static List<Reactivo> BuscarReactivo(String pLaboratorio, String pClasificacion)
        {
            List<Reactivo> Lista = new List<Reactivo>();
            using (SqlConnection ConBsq = ConexionBD.ObtenerConexion())
            {
                SqlCommand ComBsq = new SqlCommand(string.Format("Select Id, Nombre, Numero, Clasificacion, Laboratorio, Caducidad, Catalogo, Unidad, Observaciones from Reactivo where Laboratorio like '%{0}%' and Clasificacion like '%{1}%'", pLaboratorio, pClasificacion), ConBsq);
                SqlDataReader reader = ComBsq.ExecuteReader(); //Seria lo mismo que dar Ejecutar en SqlServer

                while (reader.Read()) //Mientras haya lectura
                {
                    Reactivo pReactivo = new Reactivo();
                    pReactivo.Id = reader.GetInt64(0);
                    pReactivo.Nombre = reader.GetString(1);
                    pReactivo.Numero = reader.GetString(2);
                    pReactivo.Clasificacion = reader.GetString(3);
                    pReactivo.Laboratorio = reader.GetString(4);
                    pReactivo.Caducidad = reader.GetString(5);
                    pReactivo.Catalogo = reader.GetString(6);
                    pReactivo.Unidad = reader.GetString(7);
                    pReactivo.Observacion = reader.GetString(8);

                    Lista.Add(pReactivo);
                }
                ConBsq.Close();
                return Lista;
            }
        }
    }
}
