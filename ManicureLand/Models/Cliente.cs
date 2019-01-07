using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Advertencias { get; set; }
        public Boolean Estado { get; set; }

        public Cliente() {
        }

        public Cliente(int id, string nombres, string apellidoPaterno, string apellidoMaterno, DateTime fechaNacimiento,
            string correo, string clave, string telefonoFijo, string telefonoMovil) {
            this.Id = id;
            this.Nombres = nombres;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = ApellidoMaterno;
            this.FechaNacimiento = fechaNacimiento;
            this.Correo = correo;
            this.Clave = clave;
            this.TelefonoFijo = telefonoFijo;
            this.TelefonoMovil = telefonoMovil;
            this.FechaRegistro = DateTime.Now;
            this.Advertencias = 0;
            this.Estado = true;      
        }
    }
}