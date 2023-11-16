using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsServicios
    {
        public SERVICIO servicio { get; set; }
        private DBHOTELEntities3 DBHotel = new DBHOTELEntities3();

        public List<SERVICIO> ListarServicios()
        {
            return DBHotel.SERVICIOS
                          .Where(t => t.ACTIVO == true)
                          .OrderBy(t => t.NOMBRE_SERVICIO)
                          .ToList();
        }

        public SERVICIO Consultar(int idServicio)
        {
            return DBHotel.SERVICIOS.FirstOrDefault(t => t.ID_SERVICIO == idServicio);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.SERVICIOS.Add(servicio);
                DBHotel.SaveChanges();
                return "Se insertó el Servicio: " + servicio.NOMBRE_SERVICIO + " en la base de datos";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        //Método actualizar
        public string Actualizar()
        {
            try
            {
                //Se crea un objeto de tipoProducto y se consulta
                SERVICIO _servicio = DBHotel.SERVICIOS.FirstOrDefault(t => t.ID_SERVICIO == servicio.ID_SERVICIO);
                if (_servicio == null)
                {
                    return "No se encontró el Servicio";
                }
                //TIpoPRoducto _tipoproducto = Consultar(tipoProducto.Codigo);
                //Asignar los valores a _tipoProducto del objeto que se pasó a la clase: tipoProducto
                _servicio.ID_SERVICIO = servicio.ID_SERVICIO;
                _servicio.NOMBRE_SERVICIO = servicio.NOMBRE_SERVICIO;
                _servicio.DESCRIPCION = servicio.DESCRIPCION;
                _servicio.PRECIO = servicio.PRECIO;
                _servicio.ACTIVO = servicio.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del Servicio: " + servicio.NOMBRE_SERVICIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Eliminar()
        {
            try
            {
                //Se consulta el objeto
                SERVICIO _servicio = DBHotel.SERVICIOS.FirstOrDefault(t => t.ID_SERVICIO == servicio.ID_SERVICIO);
                if (_servicio == null)
                {
                    return "No se encontró el Servicio";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.SERVICIOS.Remove(_servicio);
                DBHotel.SaveChanges();
                return "Se eliminó el Servicio: " + _servicio.NOMBRE_SERVICIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}