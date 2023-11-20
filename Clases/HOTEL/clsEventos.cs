using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios_18_20.Models;


namespace Servicios_18_20.Clases.HOTEL
{
    public class clsEventos
    {

        public EVENTO evento { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();


        //Método consultar
        public EVENTO Consultar(int idevento)
        {
            return DBHotel.EVENTOS.FirstOrDefault(t => t.ID_EVENTO == idevento);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.EVENTOS.Add(evento);
                DBHotel.SaveChanges();
                return "Se insertó el nuevo evento: " + evento.NOMBRE_EVENTO + " en la base de datos";
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
                EVENTO _evento = DBHotel.EVENTOS.FirstOrDefault(t => t.ID_EVENTO == evento.ID_EVENTO);
                if (_evento == null)
                {
                    return "No se encontró el evento";
                }
                _evento.ID_EVENTO = evento.ID_EVENTO;
                _evento.NOMBRE_EVENTO = evento.NOMBRE_EVENTO;
                _evento.DESCRIPCION = evento.DESCRIPCION;
                _evento.FECHA = evento.FECHA;
                _evento.LUGAR = evento.LUGAR;
                _evento.ID_SEDE = evento.ID_SEDE;
                _evento.ACTIVO = evento.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del evento: " + evento.NOMBRE_EVENTO;
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
                EVENTO _evento = DBHotel.EVENTOS.FirstOrDefault(t => t.ID_EVENTO == evento.ID_EVENTO);
                if (_evento == null)
                {
                    return "No se encontró el evento";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.EVENTOS.Remove(_evento);
                DBHotel.SaveChanges();
                return "Se eliminó el evento: " + _evento.NOMBRE_EVENTO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}