using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdManicurista { get; set; }
        public int IdCliente { get; set; }
        public int TiempoEstimado { get; set; }
        public int PrecioTotal { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaRegistroReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public string HoraLlegada { get; set; }
        public string HoraInicioServicio { get; set; }
        public string HoraTercminoServicio { get; set; }
        public bool Estado;

        public Reserva()
        {

        }

        public Reserva(int idReserva, int idManicurista, int idCliente, int tiempoEstimado, int precioTotal, string observacion, DateTime fechaRegistroReserva, DateTime fechaReserva, string horaLlegada, string horaInicioServicio, string horaTercminoServicio, bool estado)
        {
            IdReserva = idReserva;
            IdManicurista = idManicurista;
            IdCliente = idCliente;
            TiempoEstimado = tiempoEstimado;
            PrecioTotal = precioTotal;
            Observacion = observacion;
            FechaRegistroReserva = fechaRegistroReserva;
            FechaReserva = fechaReserva;
            HoraLlegada = horaLlegada;
            HoraInicioServicio = horaInicioServicio;
            HoraTercminoServicio = horaTercminoServicio;
            Estado = estado;
        }
    }
}