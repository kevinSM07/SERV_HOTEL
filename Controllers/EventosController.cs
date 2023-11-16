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
    public class EventosController : ApiController
    {
        public EVENTO Get(int idEvento)
        {
            clsEventos _evento = new clsEventos();
            return _evento.Consultar(idEvento);
        }
        public string Post([FromBody] EVENTO evento)
        {
            clsEventos _evento = new clsEventos();
            _evento.evento = evento;
            return _evento.Insertar();
        }
        public string Put([FromBody] EVENTO evento)
        {
            clsEventos _evento = new clsEventos();
            _evento.evento = evento;
            return _evento.Actualizar();
        }
        public string Delete(EVENTO evento)
        {
            clsEventos _evento = new clsEventos();
            _evento.evento = evento;
            return _evento.Eliminar();
        }
    }
}