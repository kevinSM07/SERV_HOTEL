using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Servicios_18_20.Models;
using Servicios_18_20.Clases;
using Servicios_18_20.Clases.HOTEL;
using System.Web.Http.Cors;

namespace Servicios_18_20.Controllers
{
    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class HabitacionesServiciosController : ApiController
    {
        public List<HABITACIONES_SERVICIOS> Get()
        {
            clsHabitaciones_Servicios _ServiciosADD = new clsHabitaciones_Servicios();
            return _ServiciosADD.ListarServiciosADD();
        }

        public HABITACIONES_SERVICIOS Get(int idServiciosAdicionales)
        {
            clsHabitaciones_Servicios _serviciosAdicionales = new clsHabitaciones_Servicios();
            return _serviciosAdicionales.Consultar(idServiciosAdicionales);
        }

    }
}