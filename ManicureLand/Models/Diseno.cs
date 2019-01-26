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
        [RegularExpression(@"^[0-9a-zA-ZñÑáéíóúÁÉÍÓÚ.\s\']+$", ErrorMessage = "Hay caracteres no permitidos.")]
        public string Descripcion { get; set; }

        [DisplayName("Minutos Estimados")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int TiempoEstimado { get; set; }

        [DisplayName("Precio $")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int Precio { get; set; }

        [DisplayName("Observación")]
        [StringLength(255)]
        [RegularExpression(@"^[0-9a-zA-ZñÑáéíóúÁÉÍÓÚ.\s\']+$", ErrorMessage = "Hay caracteres no permitidos.")]
        public string Observacion { get; set; }

        [DisplayName("Subir imagen")]
        [StringLength(8000)]
        [Required(ErrorMessage = "Campo Requerido")]
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