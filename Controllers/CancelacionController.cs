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
    public class CancelacionController : ApiController
    {
        public IQueryable Get()
        {
            clsCancelacion cancelacion = new clsCancelacion();
            return cancelacion.ListarCancelaciones();
        }
        public CANCELACIONE Get(int idCancelacion)
        {
            clsCancelacion _cancelacion = new clsCancelacion();
            return _cancelacion.Consultar(idCancelacion);
        }
        public string Post([FromBody] CANCELACIONE cancelacion)
        {
            clsCancelacion _cancelacion = new clsCancelacion();
            _cancelacion.cancelacion = cancelacion;
            return _cancelacion.Insertar();
        }
        public string Put([FromBody] CANCELACIONE cancelacion)
        {
            clsCancelacion _cancelacion = new clsCancelacion();
            _cancelacion.cancelacion = cancelacion;
            return _cancelacion.Actualizar();
        }
        public string Delete(CANCELACIONE cancelacion)
        {
            clsCancelacion _cancelacion = new clsCancelacion();
            _cancelacion.cancelacion = cancelacion;
            return _cancelacion.Eliminar();
        }
    }
}