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
    public class PersonalController : ApiController
    {

        public IQueryable Get()
        {
            clsPersonal personal = new clsPersonal();
            return personal.ListarPersonal();
        }

        public string Get(int id)
        {
            return "value";
        }
        public string Post([FromBody] PERSONAL _personal)
        {
            clsPersonal personal = new clsPersonal();
            personal.personal = _personal;
            return personal.Insertar();
        }
        public string Put([FromBody] PERSONAL _personal)
        {
            clsPersonal personal = new clsPersonal();
            personal.personal = _personal;
            return personal.Actualizar();
        }
        public string Delete([FromBody] PERSONAL _personal)
        {
            clsPersonal personal = new clsPersonal();
            personal.personal = _personal;
            return personal.Eliminar();
        }
    }
}