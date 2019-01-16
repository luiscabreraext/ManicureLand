using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public string Rut { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string RepetirClave { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Perfil { get; set; }
        public bool Estado { get; set; }

        public Empleado()
        {

        }

        public Empleado(int idEmpleado, string nombres, string apellidoPaterno, string apellidoMaterno, string fechaNacimiento, string rut, string correo, string clave, string repetirClave, string telefono, DateTime fechaRegistro, int perfil, bool estado)
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