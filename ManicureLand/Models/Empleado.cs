using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }

        [DisplayName("Nombres")]
        [StringLength(64), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string Nombres { get; set; }

        [DisplayName("Apellido Paterno")]
        [StringLength(32), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string ApellidoPaterno { get; set; }

        [DisplayName("Apellido Materno")]
        [StringLength(32), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚ\s\']+$", ErrorMessage = "Solo puede ingresar letras")]
        public string ApellidoMaterno { get; set; }

        [DisplayName("Fecha Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Debe indicar la fecha correcta")]
        public DateTime FechaNacimiento { get; set; }

        [StringLength(10), Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression(@"^([1-9]{1})+([0-9]{0,7})+\-([0-9kK]{1})+$",
                  ErrorMessage = "Formato de correo incorrecto de telefono, use un formato algo@algo.com")]
        public string Rut { get; set; }

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

        [DisplayName("Fecha Registro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistro { get; set; }

        public int Perfil { get; set; }
        public bool Estado { get; set; }

        public Empleado()
        {

        }

        public Empleado(int idEmpleado, string nombres, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento, string rut, string correo, string clave, string repetirClave, string telefono, DateTime fechaRegistro, int perfil, bool estado)
        {
            IdEmpleado = idEmpleado;
            Nombres = nombres;
            ApellidoPaterno = apellidoPaterno;
            ApellidoMaterno = apellidoMaterno;
            FechaNacimiento = fechaNacimiento;
            Rut = rut;
            Correo = correo;
            Clave = clave;
            RepetirClave = repetirClave;
            Telefono = telefono;
            FechaRegistro = fechaRegistro;
            Perfil = perfil;
            Estado = estado;
        }
    }
}