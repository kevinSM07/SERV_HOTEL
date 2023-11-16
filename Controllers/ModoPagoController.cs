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
    public class ModoPagoController : ApiController
    {
        public IQueryable Get()
        {
            clsModo_Pago modoPago = new clsModo_Pago();
            return modoPago.ListarMetodoPago();

        }

        public MODO_PAGO Get(int idModoPago)
        {
            clsModo_Pago _modoPago = new clsModo_Pago();
            return _modoPago.Consultar(idModoPago);
        }
        public string Post([FromBody] MODO_PAGO modoPago)
        {
            clsModo_Pago _modoPago = new clsModo_Pago();
            _modoPago.modoPago = modoPago;
            return _modoPago.Insertar();
        }
        public string Put([FromBody] MODO_PAGO modoPago)
        {
            clsModo_Pago _modoPago = new clsModo_Pago();
            _modoPago.modoPago = modoPago;
            return _modoPago.Actualizar();
        }
        public string Delete(MODO_PAGO modoPago)
        {
            clsModo_Pago _modoPago = new clsModo_Pago();
            _modoPago.modoPago = modoPago;
            return _modoPago.Eliminar();
        }
    }
}