using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Servicio
    {
        public int IdServicio  { get; set; }
        public string Descripcion { get; set; }
        public int TiempoEstimado { get; set; }
        public int Precio { get; set; }
        public string Observacion { get; set; }
        public string CodigoColor { get; set; }
        public bool Estado { get; set; }

        public Servicio()
        {
        }

        public Servicio(int idServicio, string descripcion, int tiempoEstimado, int precio, string observacion, string codigoColor, bool estado)
        {
            IdServicio = idServicio;
            Descripcion = descripcion;
            TiempoEstimado = tiempoEstimado;
            Precio = precio;
            Observacion = observacion;
            CodigoColor = codigoColor;
            Estado = estado;
        }
    }    
}