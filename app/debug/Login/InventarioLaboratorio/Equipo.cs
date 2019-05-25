using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioLaboratorio
{
    public class Equipo
    {
        //Propiedades
        public Int64 Id { get; set; }
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Estado { get; set; }
        public String Laboratorio { get; set; }
        public String NumITT { get; set; }
        public String Precio { get; set; }
        public String ManualOP { get; set; }
        public String NumSerie { get; set; }
        public String Observacion { get; set; }

        //Se crea un constructor vacio
        public Equipo() { }

        //Se crea un contructor que recibira los Parametros
        public Equipo(Int64 pId, String pNombre, String pMarca, String pModelo, String pEstado, String pLaboratorio, String pNumITT, String pPrecio, String pManualOP, String pNumSerie, String pObservacion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Marca = pMarca;
            this.Modelo = pModelo;
            this.Estado = pEstado;
            this.Laboratorio = pLaboratorio;
            this.NumITT = pNumITT;
            this.Precio = pPrecio;
            this.ManualOP = pManualOP;
            this.NumSerie = pNumSerie;
            this.Observacion = pObservacion;

        }
    }
}
