using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Diseno
    {
        public int IdDiseno { get; set; }
        public string Descripcion { get; set; }
        public int TiempoEstimado { get; set; }
        public int Precio { get; set; }
        public string Observacion { get; set; }
        public string UrlDiseno { get; set; }
        public bool Estado { get; set; }

        public Diseno()
        {

        }

        public Diseno( int idDiseno, string descripcion, int tiempoEstimado,int precio, string observacion, string urlDiseno, bool estado)
        {
            IdDiseno = idDiseno;
            Descripcion = descripcion;
            TiempoEstimado = tiempoEstimado;
            Precio = precio;
            Observacion = observacion;
            UrlDiseno = urlDiseno;
            Estado = estado;
        }
    }
}