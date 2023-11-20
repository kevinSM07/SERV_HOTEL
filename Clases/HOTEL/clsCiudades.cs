using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios_18_20.Models;


namespace Servicios_18_20.Clases.HOTEL
{
    public class clsCiudades
    {

        public CIUDADE ciudad { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        public IQueryable ListarCiudades()
        {
            return from CU in DBHotel.Set<CIUDADE>()
                   orderby (CU.CIUDAD_ID)
                   select new
                   {
                       Codigo_Ciudad = CU.CIUDAD_ID,
                       Nombre_Ciudad = CU.NOMBRE_CIUDAD,
                       Activo = CU.ACTIVO
                   };
        }

        //Método consultar
        public CIUDADE Consultar(int idCiudad)
        {
            return DBHotel.CIUDADES.FirstOrDefault(t => t.CIUDAD_ID == idCiudad);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.CIUDADES.Add(ciudad);
                DBHotel.SaveChanges();
                return "Se insertó la nueva Ciudad: " + ciudad.NOMBRE_CIUDAD + " en la base de datos";
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
                CIUDADE _ciudad = DBHotel.CIUDADES.FirstOrDefault(t => t.CIUDAD_ID == ciudad.CIUDAD_ID);
                if (_ciudad == null)
                {
                    return "No se encontró la Ciudad";
                }
                _ciudad.CIUDAD_ID = ciudad.CIUDAD_ID;
                _ciudad.NOMBRE_CIUDAD = ciudad.NOMBRE_CIUDAD;
                _ciudad.ACTIVO = ciudad.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información de la Ciudad: " + ciudad.NOMBRE_CIUDAD;
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
                CIUDADE _ciudad = DBHotel.CIUDADES.FirstOrDefault(t => t.CIUDAD_ID == ciudad.CIUDAD_ID);
                if (_ciudad == null)
                {
                    return "No se encontró el evento";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.CIUDADES.Remove(_ciudad);
                DBHotel.SaveChanges();
                return "Se eliminó el evento: " + _ciudad.NOMBRE_CIUDAD;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}