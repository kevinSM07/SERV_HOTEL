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
    public class TipoClienteController : ApiController
    {
        public List<TIPO_CLIENTE> Get()
        {
            clsTipo_Cliente _tipoCliente = new clsTipo_Cliente();
            return _tipoCliente.ListarTipoCliente();
        }
    }
}