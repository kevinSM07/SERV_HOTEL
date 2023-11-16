using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsPersonal
    {
        public PERSONAL personal { get; set; }
        private DBHOTELEntities3 DBHotel = new DBHOTELEntities3();

        public IQueryable ListarPersonal()
        {
            return from PL in DBHotel.Set<PERSONAL>()
                   join SE in DBHotel.Set<SEDE>()
                   on PL.ID_SEDE equals SE.ID_SEDE
                   orderby (PL.NOMBRE)
                   select new
                   {
                       Documento = PL.DOCUMENTO,
                       Nombre = PL.NOMBRE,
                       Apellido = PL.APELLIDO,
                       Telefono = PL.TELEFONO,
                       Correo = PL.CORREO_ELECTRONICO,
                       Cod_Sede = SE.ID_SEDE,
                       Nombre_Sede = SE.NOMBRE_SEDE,
                       Activo = PL.ACTIVO
                   };
        }

        public PERSONAL Consulta(string documento)
        {
            return DBHotel.PERSONALs.FirstOrDefault(e => e.DOCUMENTO == documento);
        }

        public string Insertar()
        {
            try
            {
                DBHotel.PERSONALs.Add(personal);
                DBHotel.SaveChanges();
                return "Se insertó el personal: " + personal.NOMBRE;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }
        public string Actualizar()
        {
            //DBHotel.PERSONALs.AddOrUpdate(personal);
            //DBHotel.SaveChanges();
            //return "Se actualizó el personal: " + personal.NOMBRE;
            try
            {
                PERSONAL _personal = DBHotel.PERSONALs.FirstOrDefault(t => t.DOCUMENTO == personal.DOCUMENTO);
                if (_personal == null)
                {
                    return "El personal con documento: " + personal.DOCUMENTO + ", no existe en la base de datos";
                }
                _personal.DOCUMENTO = personal.DOCUMENTO;
                _personal.NOMBRE = personal.NOMBRE;
                _personal.APELLIDO = personal.APELLIDO;
                _personal.TELEFONO = personal.TELEFONO;
                _personal.CORREO_ELECTRONICO = personal.CORREO_ELECTRONICO;
                _personal.ID_SEDE = personal.ID_SEDE;
                _personal.ACTIVO = personal.ACTIVO;
                DBHotel.SaveChanges();
                return "Se actualizo el personal con documento: " + personal.DOCUMENTO;
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
                PERSONAL _personal = DBHotel.PERSONALs.FirstOrDefault(t => t.DOCUMENTO == personal.DOCUMENTO);
                if (_personal == null)
                {
                    return "El personal con documento: " + personal.DOCUMENTO + ", no existe en la base de datos";
                }
                DBHotel.PERSONALs.Remove(_personal);
                DBHotel.SaveChanges();
                return "Se eliminó el personal de la base de datos, con numero de documento: " + personal.DOCUMENTO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}