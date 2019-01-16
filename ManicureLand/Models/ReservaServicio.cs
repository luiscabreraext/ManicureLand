using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class ReservaServicio
    {
        public int IdReserva { get; set; }
        public int IdServicio { get; set; }
        
        public ReservaServicio()
        {

        }

        public ReservaServicio(int idReserva, int idServicio)
        {
            IdReserva = idReserva;
            IdServicio = idServicio;
        }
    }
}