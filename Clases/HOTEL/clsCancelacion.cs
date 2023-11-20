using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsCancelacion
    {
        public CANCELACIONE cancelacion { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        public IQueryable ListarCancelaciones()
        {
            return from C in DBHotel.Set<CANCELACIONE>()
                   orderby (C.ID_CANCELACION)
                   select new
                   {
                       Codigo_Cancelacion = C.ID_CANCELACION,
                       Descripcion = C.DESCRIPCION,
                       Activo = C.ACTIVO
                   };
        }

        public CANCELACIONE Consultar(int idCancelacion)
        {
            return DBHotel.CANCELACIONES.FirstOrDefault(t => t.ID_CANCELACION == idCancelacion);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.CANCELACIONES.Add(cancelacion);
                DBHotel.SaveChanges();
                return "Se insertó cancelacion con descripción: " + cancelacion.DESCRIPCION + " y numero de ID: "+ cancelacion.ID_CANCELACION + " en la base de datos";
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
                CANCELACIONE _cancelacion = DBHotel.CANCELACIONES.FirstOrDefault(t => t.ID_CANCELACION == cancelacion.ID_CANCELACION);
                if (_cancelacion == null)
                {
                    return "No se encontró la cancelacion registrada";
                }
                _cancelacion.ID_CANCELACION = cancelacion.ID_CANCELACION;
                _cancelacion.DESCRIPCION = cancelacion.DESCRIPCION;
                _cancelacion.ACTIVO = cancelacion.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del la cancelación con ID: " + cancelacion.ID_CANCELACION;
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
                CANCELACIONE _cancelacion = DBHotel.CANCELACIONES.FirstOrDefault(t => t.ID_CANCELACION == cancelacion.ID_CANCELACION);
                if (_cancelacion == null)
                {
                    return "No se encontró el evento";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.CANCELACIONES.Remove(_cancelacion);
                DBHotel.SaveChanges();
                return "Se eliminó la descripción: " + _cancelacion.DESCRIPCION + "con ID: " + _cancelacion.ID_CANCELACION;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}