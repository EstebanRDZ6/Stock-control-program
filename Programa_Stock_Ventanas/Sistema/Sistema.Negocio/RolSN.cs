using Sistema.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Negocio
{
    public class RolSN
    {
        public static DataTable Listar()
        {
            RolSD Datos = new RolSD();
            return Datos.Listar();
        }
    }
}
