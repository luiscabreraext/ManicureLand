using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Turno
    {
        public int IdTurno { get; set; }
        public string IdManicurista { get; set; }
        public DateTime FechaInico { get; set; }
        public DateTime FechaTermino { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public string HoraInicioColacion { get; set; }
        public string HoraTerminoColacion { get; set; }

        public Turno()
        {

        }

        public Turno(int idTurno, string idManicurista, DateTime fechaInico, DateTime fechaTermino, string horaInicio, string horaTermino, string horaInicioColacion, string horaTerminoColacion)
        {
            IdTurno = idTurno;
            IdManicurista = idManicurista;
            FechaInico = fechaInico;
            FechaTermino = fechaTermino;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            HoraInicioColacion = horaInicioColacion;
            HoraTerminoColacion = horaTerminoColacion;
        }
    }

}