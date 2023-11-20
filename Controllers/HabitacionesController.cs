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
        public IQueryable Get()
        {
            clsHabitaciones habitaciones = new clsHabitaciones();
            return habitaciones.ListarXHabitacioneo();
        }

        public IQueryable Get(int tipoHabitacion)
        {
            clsHabitaciones habitaciones = new clsHabitaciones();
            return habitaciones.ConsultarXTipoHabitacion(tipoHabitacion);
        }

        public HABITACIONE Get(int idHabitacion, string nada)
        {
            clsHabitaciones _habitaciones = new clsHabitaciones();
            return _habitaciones.Consultar(idHabitacion, nada);
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