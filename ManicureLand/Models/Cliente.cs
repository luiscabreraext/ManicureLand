using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }

        [DisplayName("Nombres")]
        [StringLength(64), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[a-zA-ZñÑ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string Nombres { get; set; }

        [DisplayName("Apellido Paterno")]
        [StringLength(32), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[a-zA-ZñÑ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        [StringLength(32)]
        [RegularExpression(@"^[a-zA-ZñÑ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string ApellidoMaterno { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe indicar la fecha correcta")]
        public DateTime FechaNacimiento { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Ingrese un correo correctamente.")]
        [StringLength(255), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.([a-zA-Z]{2,4})+$",
                   ErrorMessage = "Formato de correo incorrecto de telefono, use un formato algo@algo.com")]
        public string Correo { get; set; }

        [RegularExpression(@"^[a-zA-Z]{1}[a-zA-Z0-9!@#\$\*&]{3,31}$",
                  ErrorMessage = "Su contraseña debe empezar por una letra seguida de números, letras o los simbolos !, @, #, $, &, o * con un mínimo de 4 caracteres y máximo 32.")]
        [Compare("RepetirClave", ErrorMessage = "Las constraseñas no coinciden")]
        public string Clave { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]{1}[a-zA-Z0-9!@#\$\*&]{3,31}$",
                  ErrorMessage = "Su contraseña debe empezar por una letra seguida de números, letras o los simbolos !, @, #, $, &, o * con un mínimo de 4 caracteres y máximo 32.")]
                public string RepetirClave { get; set; }

        [RegularExpression(@"^[\+]{1}[0-9]{11}$",
                   ErrorMessage = "Formato incorrecto de telefono, use +56212345678.")]
        public string Telefono { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        public int Advertencias { get; set; }
        public Boolean Estado { get; set; }

        public Cliente() {
        }

        public Cliente(int idCliente, string nombres, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento,
            string correo, string clave, string telefono) {
            this.IdCliente = idCliente;
            this.Nombres = nombres;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.FechaNacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Clave = clave;
            this.Telefono = telefono;
            this.FechaRegistro = DateTime.Now;
            this.Advertencias = 0;
            this.Estado = true;      
        }
    }
}