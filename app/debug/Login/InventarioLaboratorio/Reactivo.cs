using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioLaboratorio
{
    public class Reactivo
    {
        //Propiedades
        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Numero { get; set; }
        public String Clasificacion { get; set; }
        public String Laboratorio { get; set; }
        public String Caducidad { get; set; }
        public String Catalogo { get; set; }
        public String Unidad { get; set; }
        public String Observacion { get; set; }
        

        //Se crea un constructor vacio
        public Reactivo() { }

        //Se crea un contructor que recibira los Parametros
        public Reactivo(Int64 pId, String pNombre, String pNumero, String pCatalogo, String pLaboratorio, String pCaducidad, String pUnidad, String pObservacion, String pClasificacion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Numero = pNumero;
            this.Clasificacion = pClasificacion;
            this.Laboratorio = pLaboratorio;
            this.Caducidad = pCaducidad;
            this.Catalogo = pCatalogo;
            this.Unidad = pUnidad;
            this.Observacion = pObservacion;
            
        }
    }
}
