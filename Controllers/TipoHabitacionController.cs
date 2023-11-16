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
    public class TipoHabitacionController : ApiController
    {
        public List<TIPO_HABITACION> Get()
        {
            clsTipo_Habitacion _tipoHabitacion = new clsTipo_Habitacion();
            return _tipoHabitacion.ListarTipoHabitaciones();
        }

        public TIPO_HABITACION Get(int idTipoHabitacion)
        {
            clsTipo_Habitacion _TipoHabitacion = new clsTipo_Habitacion();
            return _TipoHabitacion.Consultar(idTipoHabitacion);
        }
        public string Post([FromBody] TIPO_HABITACION TipoHabitacion)
        {
            clsTipo_Habitacion _TipoHabitacion = new clsTipo_Habitacion();
            _TipoHabitacion.TipoHabitacion = TipoHabitacion;
            return _TipoHabitacion.Insertar();
        }
        public string Put([FromBody] TIPO_HABITACION TipoHabitacion)
        {
            clsTipo_Habitacion _TipoHabitacion = new clsTipo_Habitacion();
            _TipoHabitacion.TipoHabitacion = TipoHabitacion;
            return _TipoHabitacion.Actualizar();
        }
        public string Delete(TIPO_HABITACION TipoHabitacion)
        {
            clsTipo_Habitacion _TipoHabitacion = new clsTipo_Habitacion();
            _TipoHabitacion.TipoHabitacion = TipoHabitacion;
            return _TipoHabitacion.Eliminar();
        }
    }
}