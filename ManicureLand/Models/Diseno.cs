using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Diseno
    {
        public int IdDiseno { get; set; }

        [DisplayName("Descripción")]
        [StringLength(64), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[0-9a-zA-ZñÑ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string Descripcion { get; set; }

        [DisplayName("Minutos Estimados")]
        public int TiempoEstimado { get; set; }

        [DisplayName("Precio $")]
        public int Precio { get; set; }

        [DisplayName("Observación")]
        [StringLength(255)]
        [RegularExpression(@"^[0-9a-zA-ZñÑ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string Observacion { get; set; }

        [DisplayName("Subir imagen")]
        [StringLength(8000)]
        //[Url]
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