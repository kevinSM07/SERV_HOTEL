using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases
{
    public class clsReservas
    {
        public RESERVA reservas { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        //public IQueryable ConsultarReservas()
        //{
        //    return from CL in DBHotel.Set<CLIENTE>()
        //           join RE in DBHotel.Set<RESERVA>() on CL.ID_CLIENTE equals RE.ID_CLIENTE
        //           join FA in DBHotel.Set<FACTURA>() on CL.ID_CLIENTE equals FA.ID_CLIENTE
        //           join SE in DBHotel.Set<SEDE>() on FA.ID_SEDE equals SE.ID_SEDE
        //           join HB in DBHotel.Set<HABITACIONE>() on FA.NUMERO_HABITACION equals HB.NUMERO_HABITACION
        //           orderby (CL.NOMBRE)
        //           select new
        //           {
        //               COD_RESERVA = RE.ID_RESERVA,
        //               COD_CLIENTE = CL.ID_CLIENTE,
        //               NOMBRE = CL.NOMBRE,
        //               SEDE = SE.NOMBRE_SEDE,
        //               HABITACION = HB.NUMERO_HABITACION,
        //               PRECIO_REV = RE.PRECIO_RESERVA,
        //               FECHA_ENTRADA_IN = RE.FECHA_ENTRADA,
        //               FECHA_SALIDA_OUT = RE.FECHA_SALIDA,
        //               ESTADO_RESERVAA = RE.ESTADO_RESERVA
        //           };
        //}

        public List<RESERVA> ListarReservas()
        {
            return DBHotel.RESERVAS
                          .Where(t => t.ESTADO_RESERVA == true)
                          .OrderBy(t => t.ID_RESERVA)
                          .ToList();
        }

        public RESERVA Consultar(int idCliente)
        {
            return DBHotel.RESERVAS.FirstOrDefault(e => e.ID_CLIENTE == idCliente);
        }
        public string Insertar()
        {
            
            try
            {
                DBHotel.RESERVAS.Add(reservas);
                DBHotel.SaveChanges();
                return "Se grabó la reserva con el numero de reserva: " + reservas.ID_RESERVA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Actualizar()
        {
            try
            {
                RESERVA _reserva = Consultar(reservas.ID_RESERVA);
                if (_reserva == null)
                {
                    return "El codigó de reserva: " + reservas.ID_RESERVA + ", no existe en la base de datos";
                }
                _reserva.ID_CLIENTE = reservas.ID_CLIENTE;
                _reserva.NOMBRE = reservas.NOMBRE;
                _reserva.TELEFONO = reservas.TELEFONO;
                _reserva.CANTIDAD_C = reservas.CANTIDAD_C;
                _reserva.ID_SEDE = reservas.ID_SEDE;
                _reserva.NUMERO_HABITACION = reservas.NUMERO_HABITACION;
                _reserva.ID_ENTRADA_SALIDA = reservas.ID_ENTRADA_SALIDA;
                _reserva.ID_SERVICIO = reservas.ID_SERVICIO;
                _reserva.ID_CANCELACION = reservas.ID_CANCELACION;
                _reserva.ID_EVENTO = reservas.ID_EVENTO;
                _reserva.FECHA_ENTRADA = reservas.FECHA_ENTRADA;
                _reserva.FECHA_SALIDA = reservas.FECHA_SALIDA;
                _reserva.ID_ENTRADA_SALIDA = reservas.ID_ENTRADA_SALIDA;
                _reserva.PRECIO_RESERVA = reservas.PRECIO_RESERVA;
                _reserva.ESTADO_RESERVA = reservas.ESTADO_RESERVA;
                DBHotel.SaveChanges();
                return "Se actualizó la reserva con el numero de reserva: " + reservas.ID_RESERVA;
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
                RESERVA _reserva = Consultar(reservas.ID_RESERVA);
                if (_reserva == null)
                {
                    return "La reserva con numero de reserva: " + reservas.ID_RESERVA + ", no existe en la base de datos";
                }
                DBHotel.RESERVAS.Remove(_reserva);
                DBHotel.SaveChanges();
                return "Se eliminó la reserva de la base de datos, con numero de reserva: " + reservas.ID_RESERVA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}