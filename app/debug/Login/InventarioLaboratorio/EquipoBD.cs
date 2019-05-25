using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventarioLaboratorio
{
    public class EquipoBD
    {
        public static int AgregarEquipo(Equipo pEquipo)
        {
            int retorno = 0;
            
            using (SqlConnection Conn = ConexionBD.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert Into Equipo(Nombre, Marca, Modelo, Estado, Laboratorio, NumITT, NumSEP, ManualOP, NumSerie, Observaciones) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                    pEquipo.Nombre, pEquipo.Marca, pEquipo.Modelo, pEquipo.Estado, pEquipo.Laboratorio, pEquipo.NumITT, pEquipo.Precio, pEquipo.ManualOP, pEquipo.NumSerie, pEquipo.Observacion), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            //Como se creo un metodo static debe retornar algo o marcara error
            return retorno;
        }

        public static List<Equipo> BuscarEquipo(String pLaboratorio, String pEstado)
        {
            List<Equipo> ListaEq = new List<Equipo>();
            using (SqlConnection ConBsq = ConexionBD.ObtenerConexion())
            {
                SqlCommand ComBsq = new SqlCommand(string.Format("Select Id, Nombre, Marca, Modelo, Estado, Laboratorio, NumITT, NumSEP, ManualOP, NumSerie, Observaciones from Equipo where Laboratorio like '%{0}%' and Estado like '%{1}%' ", pLaboratorio, pEstado), ConBsq);
                SqlDataReader lector = ComBsq.ExecuteReader();

                while (lector.Read())
                {
                    Equipo pEquipo = new Equipo();
                    pEquipo.Id = lector.GetInt64(0);
                    pEquipo.Nombre = lector.GetString(1);
                    pEquipo.Marca = lector.GetString(2);
                    pEquipo.Modelo = lector.GetString(3);
                    pEquipo.Estado = lector.GetString(4);
                    pEquipo.Laboratorio = lector.GetString(5);
                    pEquipo.NumITT = lector.GetString(6);
                    pEquipo.Precio = lector.GetString(7);
                    pEquipo.ManualOP = lector.GetString(8);
                    pEquipo.NumSerie = lector.GetString(9);
                    pEquipo.Observacion = lector.GetString(10);

                    ListaEq.Add(pEquipo);
                }
                ConBsq.Close();
                return ListaEq;
            }
        }
    }
}
