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
    public class ServicioController : ApiController
    {
        public List<SERVICIO> Get()
        {
            clsServicios _Servicios = new clsServicios();
            return _Servicios.ListarServicios();
        }
        public SERVICIO Get(int idServicio)
        {
            clsServicios _servicio = new clsServicios();
            return _servicio.Consultar(idServicio);
        }
        public string Post([FromBody] SERVICIO servicio)
        {
            clsServicios _servicio = new clsServicios();
            _servicio.servicio = servicio;
            return _servicio.Insertar();
        }
        public string Put([FromBody] SERVICIO servicio)
        {
            clsServicios _servicio = new clsServicios();
            _servicio.servicio = servicio;
            return _servicio.Actualizar();
        }
        public string Delete(SERVICIO servicio)
        {
            clsServicios _servicio = new clsServicios();
            _servicio.servicio = servicio;
            return _servicio.Eliminar();
        }
    }
}