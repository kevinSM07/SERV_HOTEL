using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsHabitaciones_Servicios
    {
        public HABITACIONES_SERVICIOS servicioADD { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        public List<HABITACIONES_SERVICIOS> ListarServiciosADD()
        {
            return DBHotel.HABITACIONES_SERVICIOS
                          .Where(t => t.ACTIVO == true)
                          .OrderBy(t => t.NOMBRE_SERVICIO_AD)
                          .ToList();
        }

        public HABITACIONES_SERVICIOS Consultar(int idServiciosAdicionales)
        {
            return DBHotel.HABITACIONES_SERVICIOS.FirstOrDefault(t => t.ID_HABITACIONES_SERVICIOS == idServiciosAdicionales);
        }

    }
}