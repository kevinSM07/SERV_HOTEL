using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsSedes
    {
        public SEDE SEDES { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();
        public List<SEDE> ListarSedes()
        {
            return DBHotel.SEDES
                          .Where(t => t.ACTIVO == true)
                          .OrderBy(t => t.NOMBRE_SEDE)
                          .ToList();
        }
    }
}