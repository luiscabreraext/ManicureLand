using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Servicio
    {
        public int IdServicio  { get; set; }

        [DisplayName("Descripción")]
        [StringLength(64), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[0-9a-zA-ZñÑáéíóúÁÉÍÓÚ.\s\']+$", ErrorMessage = "Solo puede ingresar letras y números")]
        public string Descripcion { get; set; }

        [DisplayName("Minutos Estimados")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int TiempoEstimado { get; set; }

        [DisplayName("Precio $")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int Precio { get; set; }

        [DisplayName("Observación")]
        [StringLength(255)]
        [RegularExpression(@"^[0-9a-zA-ZñÑáéíóúÁÉÍÓÚ.\s\']+$", ErrorMessage = "Solo puede ingresar letras y números")]
        public string Observacion { get; set; }

        [DisplayName("Código Color")]
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