using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class Dedo
    {
        public int IdDedo { get; set; }
        public string Extremidad { get; set; }
        public string Descripción { get; set; }

        public Dedo()
        {

        }

        public Dedo(int idDedo, string extremidad, string descripción)
        {
            IdDedo = idDedo;
            Extremidad = extremidad;
            Descripción = descripción;
        }
    }
}