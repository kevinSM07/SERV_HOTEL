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
    public class ClienteController : ApiController
    {
        public List<CLIENTE> Get()
        {
            clsClientes _cliente = new clsClientes();
            return _cliente.ListarClientes();
        }
        public CLIENTE Get(string documento)
        {
            clsClientes _cliente = new clsClientes();
            return _cliente.Consultar(documento);
        }
        public string Post([FromBody] CLIENTE cliente)
        {
            clsClientes _cliente = new clsClientes();
            _cliente.cliente = cliente;
            return _cliente.Insertar();
        }
        public string Put([FromBody] CLIENTE cliente)
        {
            clsClientes _cliente = new clsClientes();
            _cliente.cliente = cliente;
            return _cliente.Actualizar();
        }
        public string Delete(CLIENTE cliente)
        {
            clsClientes _cliente = new clsClientes();
            _cliente.cliente = cliente;
            return _cliente.Eliminar();
        }
    }
}