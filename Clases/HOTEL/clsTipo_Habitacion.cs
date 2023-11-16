using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsTipo_Habitacion
    {

        public TIPO_HABITACION TipoHabitacion { get; set; }
        private DBHOTELEntities3 DBHotel = new DBHOTELEntities3();


        public List<TIPO_HABITACION> ListarTipoHabitaciones()
        {
            return DBHotel.TIPO_HABITACION
                          .Where(t => t.ACTIVO == true)
                          .OrderBy(t => t.TIPO)
                          .ToList();
        }

        //Método consultar
        public TIPO_HABITACION Consultar(int idTipoHabitacion)
        {
            return DBHotel.TIPO_HABITACION.FirstOrDefault(t => t.ID_TIPO_HABITACION == idTipoHabitacion);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.TIPO_HABITACION.Add(TipoHabitacion);
                DBHotel.SaveChanges();
                return "Se insertó la nueva Habitación: " + TipoHabitacion.DESCRIPCION + " en la base de datos";
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
                TIPO_HABITACION _TipoHabitacion = DBHotel.TIPO_HABITACION.FirstOrDefault(t => t.ID_TIPO_HABITACION == TipoHabitacion.ID_TIPO_HABITACION);
                if (_TipoHabitacion == null)
                {
                    return "No se encontró el Tipo de Habitación";
                }
                _TipoHabitacion.ID_TIPO_HABITACION = TipoHabitacion.ID_TIPO_HABITACION;
                _TipoHabitacion.TIPO = TipoHabitacion.TIPO;
                _TipoHabitacion.DESCRIPCION = TipoHabitacion.DESCRIPCION;
                _TipoHabitacion.ACTIVO = TipoHabitacion.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del Tipo de Habitación: " + TipoHabitacion.DESCRIPCION;
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
                TIPO_HABITACION _TipoHabitacion = DBHotel.TIPO_HABITACION.FirstOrDefault(t => t.ID_TIPO_HABITACION == TipoHabitacion.ID_TIPO_HABITACION);
                if (_TipoHabitacion == null)
                {
                    return "No se encontró el Tipo de Habitación";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.TIPO_HABITACION.Remove(_TipoHabitacion);
                DBHotel.SaveChanges();
                return "Se eliminó el Tipo de Habitación: " + _TipoHabitacion.DESCRIPCION;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}