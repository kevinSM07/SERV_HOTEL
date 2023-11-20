using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsHabitaciones
    {
        public HABITACIONE habitaciones { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        public IQueryable ListarXHabitacioneo()
        {
            return from HB in DBHotel.Set<HABITACIONE>()
                   join TH in DBHotel.Set<TIPO_HABITACION>()
                   on HB.ID_TIPO_HABITACION equals TH.ID_TIPO_HABITACION
                   join SAD in DBHotel.Set<HABITACIONES_SERVICIOS>()
                   on HB.ID_SERVICIOS_ADICIONALES equals SAD.ID_HABITACIONES_SERVICIOS
                   orderby (HB.ACTIVO)
                   select new
                   {
                       NUMERO_HABITACION = HB.NUMERO_HABITACION,
                       TIPO = TH.TIPO,
                       TARIFA_NOCHE = HB.TARIFA_NOCHE,
                       NOMBRE_SERVICIO_AD = SAD.NOMBRE_SERVICIO_AD,
                       PRECIO_SAD = SAD.PRECIO,
                       ACTIVO = HB.ACTIVO
                   };
        }

        public IQueryable ConsultarXTipoHabitacion(int TipoHabitacion)
        {
            return from HB in DBHotel.Set<HABITACIONE>()
                   where HB.ID_TIPO_HABITACION == TipoHabitacion
                   select new
                   {
                       NUMERO_HABITACION = HB.NUMERO_HABITACION,
                   };
        }


        //Método consultar
        public HABITACIONE Consultar(int idHabitacion, string nada)
        {
            return DBHotel.HABITACIONES.FirstOrDefault(t => t.NUMERO_HABITACION == idHabitacion);
            var Nada = nada;
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.HABITACIONES.Add(habitaciones);
                DBHotel.SaveChanges();
                return "Se insertó la nueva Habitación con numero: " + habitaciones.NUMERO_HABITACION + " en la base de datos";
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
                HABITACIONE _habitaciones = DBHotel.HABITACIONES.FirstOrDefault(t => t.NUMERO_HABITACION == habitaciones.NUMERO_HABITACION);
                if (_habitaciones == null)
                {
                    return "No se encontró la Factura";
                }
                _habitaciones.NUMERO_HABITACION = habitaciones.NUMERO_HABITACION;
                _habitaciones.ID_TIPO_HABITACION = habitaciones.ID_TIPO_HABITACION;
                _habitaciones.TARIFA_NOCHE = habitaciones.TARIFA_NOCHE;
                _habitaciones.DISPONIBILIDAD = habitaciones.DISPONIBILIDAD;
                _habitaciones.ID_SERVICIOS_ADICIONALES = habitaciones.ID_SERVICIOS_ADICIONALES;
                _habitaciones.ACTIVO = habitaciones.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información de la Habitación numero: " + habitaciones.NUMERO_HABITACION;
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
                HABITACIONE _habitaciones = DBHotel.HABITACIONES.FirstOrDefault(t => t.NUMERO_HABITACION == habitaciones.NUMERO_HABITACION);
                if (_habitaciones == null)
                {
                    return "No se encontró la Factura";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.HABITACIONES.Remove(_habitaciones);
                DBHotel.SaveChanges();
                return "Se eliminó la Habitacion numero: " + _habitaciones.NUMERO_HABITACION;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}