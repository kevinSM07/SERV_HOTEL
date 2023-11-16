using Servicios_18_20.Clases.HOTEL;
using Servicios_18_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Servicios_18_20.Controllers
{
    [EnableCors(origins: "http://localhost:53462", headers: "*", methods: "*")]
    public class SedeController : ApiController
    {
        public List<SEDE> Get()
        {
            clsSedes sedes = new clsSedes();
            return sedes.ListarSedes();
        }
    }
}