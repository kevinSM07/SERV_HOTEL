using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsTipo_Cliente
    {
        public TIPO_CLIENTE TIPO_CLIENTE { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();
        public List<TIPO_CLIENTE> ListarTipoCliente()
        {
            return DBHotel.TIPO_CLIENTE
                          .Where(t => t.ACTIVO == true)
                          .OrderBy(t => t.NOMBRE)
                          .ToList();
        }
    }
}