using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class ReservaDedo
    {
        public int IdReserva { get; set; }
        public int IdDedo { get; set; }
        public int IdDiseno { get; set; }
       
        public ReservaDedo()
        {

        }

        public ReservaDedo(int idReserva, int idDedo, int idDiseno)
        {
            IdReserva = idReserva;
            IdDedo = idDedo;
            IdDiseno = idDiseno;
        }
    }
}