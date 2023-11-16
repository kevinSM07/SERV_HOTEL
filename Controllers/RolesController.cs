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
    public class RolesController : ApiController
    {
        public IQueryable Get()
        {
            clsRoles roles = new clsRoles();
            return roles.ListarRoles();
        }
        public ROLE Get(int idRoles)
        {
            clsRoles _roles = new clsRoles();
            return _roles.Consultar(idRoles);
        }
        public string Post([FromBody] ROLE roles)
        {
            clsRoles _roles = new clsRoles();
            _roles.roles = roles;
            return _roles.Insertar();
        }
        public string Put([FromBody] ROLE roles)
        {
            clsRoles _roles = new clsRoles();
            _roles.roles = roles;
            return _roles.Actualizar();
        }
        public string Delete(ROLE roles)
        {
            clsRoles _roles = new clsRoles();
            _roles.roles = roles;
            return _roles.Eliminar();
        }
    }
}