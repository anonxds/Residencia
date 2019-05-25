using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioLaboratorio
{
    public class Material
    {
        //Propiedades
        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Tipo { get; set; }
        public String Capacidad { get; set; }
        public String Estado { get; set; }
        public String Laboratorio { get; set; }
        public String Observacion { get; set; }

        //Se crea un constructor vacio
        public Material() { }

        //Se crea un contructor que recibira los Parametros
        public Material(Int64 pId, String pNombre, String pTipo, String pCapacidad, String pEstado, String pLaboratorio, String pObservacion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Tipo = pTipo;
            this.Capacidad = pCapacidad;
            this.Estado = pEstado;
            this.Laboratorio = pLaboratorio;
            this.Observacion = pObservacion;
        }
    }
}
