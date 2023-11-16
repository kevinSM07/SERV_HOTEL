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
    public class HabitacionesController : ApiController
    {
        public List<HABITACIONE> Get()
        {
            clsHabitaciones _habitaciones = new clsHabitaciones();
            return _habitaciones.ListarHabitaciones();
        }

        public HABITACIONE Get(int idHabitacion)
        {
            clsHabitaciones _habitaciones = new clsHabitaciones();
            return _habitaciones.Consultar(idHabitacion);
        }
        public string Post([FromBody] HABITACIONE habitaciones)
        {
            clsHabitaciones _habitaciones = new clsHabitaciones();
            _habitaciones.habitaciones = habitaciones;
            return _habitaciones.Insertar();
        }
        public string Put([FromBody] HABITACIONE habitaciones)
        {
            clsHabitaciones _habitaciones = new clsHabitaciones();
            _habitaciones.habitaciones = habitaciones;
            return _habitaciones.Actualizar();
        }
        public string Delete(HABITACIONE habitaciones)
        {
            clsHabitaciones _habitaciones = new clsHabitaciones();
            _habitaciones.habitaciones = habitaciones;
            return _habitaciones.Eliminar();
        }
    }
}