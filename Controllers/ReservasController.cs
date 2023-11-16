using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Servicios_18_20.Clases;
using Servicios_18_20.Models;
using System.Web.Http.Cors;
using Servicios_18_20.Clases.HOTEL;

namespace Servicios_18_20.Controllers
{
    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class ReservasController : ApiController
    {
        // GET api/<controller>
        
        //public IQueryable Get()
        //{
        //    clsReservas reservas = new clsReservas();
        //    return reservas.ConsultarReservas();
        //}

        
        public List<RESERVA> Get()
        {
            clsReservas _reservas = new clsReservas();
            return _reservas.ListarReservas();
        }

        // GET api/<controller>/5
        public RESERVA Get(int idCliente)
        {
            clsReservas reservas = new clsReservas();
            return reservas.Consultar(idCliente);
        }

        // POST api/<controller>
        public string Post([FromBody] RESERVA _reservas)
        {
            clsReservas reservas = new clsReservas();
            reservas.reservas = _reservas;
            return reservas.Insertar();
        }

        // PUT api/<controller>/5
        public string Put([FromBody] RESERVA _reservas)
        {
            clsReservas reservas = new clsReservas();
            reservas.reservas = _reservas;
            return reservas.Actualizar();
        }

        // DELETE api/<controller>/5
        public string Delete([FromBody] RESERVA _reservas)
        {
            clsReservas reservas = new clsReservas();
            reservas.reservas = _reservas;
            return reservas.Eliminar();
        }
    }
}