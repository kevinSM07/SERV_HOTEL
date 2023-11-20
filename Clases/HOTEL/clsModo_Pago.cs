using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsModo_Pago
    {
        public MODO_PAGO modoPago { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        public IQueryable ListarMetodoPago()
        {
            return from MP in DBHotel.Set<MODO_PAGO>()
                   orderby (MP.METODO_PAGO)
                   select new
                   {
                       Codigo_Modo_Pago = MP.ID_MODO_PAGO,
                       Metodo_Pago = MP.METODO_PAGO,
                       Activo = MP.ACTIVO
                   };
        }

        //Método consultar
        public MODO_PAGO Consultar(int idModoPago)
        {
            return DBHotel.MODO_PAGO.FirstOrDefault(t => t.ID_MODO_PAGO == idModoPago);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.MODO_PAGO.Add(modoPago);
                DBHotel.SaveChanges();
                return "Se insertó el método de pago: " + modoPago.METODO_PAGO + " en la base de datos";
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
                MODO_PAGO _modoPago = DBHotel.MODO_PAGO.FirstOrDefault(t => t.ID_MODO_PAGO == modoPago.ID_MODO_PAGO);
                if (_modoPago == null)
                {
                    return "No se encontró el método de pago";
                }
                _modoPago.ID_MODO_PAGO = modoPago.ID_MODO_PAGO;
                _modoPago.METODO_PAGO = modoPago.METODO_PAGO;
                _modoPago.ACTIVO = modoPago.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del método de pago: " + modoPago.METODO_PAGO;
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
                MODO_PAGO _modoPago = DBHotel.MODO_PAGO.FirstOrDefault(t => t.ID_MODO_PAGO == modoPago.ID_MODO_PAGO);
                if (_modoPago == null)
                {
                    return "No se encontró la Factura";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.MODO_PAGO.Remove(_modoPago);
                DBHotel.SaveChanges();
                return "Se eliminó el método de pago: " + _modoPago.METODO_PAGO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}