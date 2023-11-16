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
    public class FacturaController : ApiController
    {
        // POST api/<controller>
        public int Post([FromBody] FACTURA factura)
        {
            clsFactura _factura = new clsFactura();
            _factura.factura = factura;
            return _factura.GrabarFactura();
        }
    }
}