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
    public class CiudadesController : ApiController
    {
        public IQueryable Get()
        {
            clsCiudades ciudades = new clsCiudades();
            return ciudades.ListarCiudades();
        }
        public CIUDADE Get(int idCiudad)
        {
            clsCiudades _ciudad = new clsCiudades();
            return _ciudad.Consultar(idCiudad);
        }
        public string Post([FromBody] CIUDADE ciudad)
        {
            clsCiudades _ciudad = new clsCiudades();
            _ciudad.ciudad = ciudad;
            return _ciudad.Insertar();
        }
        public string Put([FromBody] CIUDADE ciudad)
        {
            clsCiudades _ciudad = new clsCiudades();
            _ciudad.ciudad = ciudad;
            return _ciudad.Actualizar();
        }
        public string Delete(CIUDADE ciudad)
        {
            clsCiudades _ciudad = new clsCiudades();
            _ciudad.ciudad = ciudad;
            return _ciudad.Eliminar();
        }
    }
}