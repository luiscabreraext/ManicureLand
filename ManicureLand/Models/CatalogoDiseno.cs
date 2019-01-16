using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class CatalogoDiseno
    {
        public int IdDiseno { get; set; }
        public int IdManicurista { get; set; }

        public  CatalogoDiseno()
        {

        }

        public CatalogoDiseno(int idDiseno, int idManicurista)
        {
            IdDiseno = idDiseno;
            IdManicurista = idManicurista;
        }
    }
}