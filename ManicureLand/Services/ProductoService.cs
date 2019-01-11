using ManicureLand.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ManicureLand.Services
{
    public class ProductoService
    {
        public Boolean RegistrarProd(Producto prod)
        {
            DBAccess dBAccess = new DBAccess();
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("producto", prod.Nombre),
                new SqlParameter("precio", int.Parse(prod.Precio.ToString()))                
            };

            if (dBAccess.InsertarDatos("producto", parametros))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}