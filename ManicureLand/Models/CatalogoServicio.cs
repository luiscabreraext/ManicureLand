using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManicureLand.Models
{
    public class CatalogoServicio
    {
        public int IdDiseno { get; set; }
        public int IdManicurista { get; set; }

        public CatalogoServicio()
        {

        }

        public CatalogoServicio(int idDiseno, int idManicurista)
        {
            IdDiseno = idDiseno;
            IdManicurista = idManicurista;
        }
    }
}