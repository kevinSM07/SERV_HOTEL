using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsRoles
    {

        public ROLE roles { get; set; }
        private DBHOTELEntities3 DBHotel = new DBHOTELEntities3();

        public IQueryable ListarRoles()
        {
            return from R in DBHotel.Set<ROLE>()
                   orderby (R.ID_ROL)
                   select new
                   {
                       Codigo_Rol = R.ID_ROL,
                       Nombre_Rol = R.NOMBRE_ROL,
                       Activo = R.ACTIVO
                   };
        }

        //Método consultar
        public ROLE Consultar(int idRoles)
        {
            return DBHotel.ROLES.FirstOrDefault(t => t.ID_ROL == idRoles);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.ROLES.Add(roles);
                DBHotel.SaveChanges();
                return "Se insertó el nuevo Rol: " + roles.NOMBRE_ROL + " en la base de datos";
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
                ROLE _roles = DBHotel.ROLES.FirstOrDefault(t => t.ID_ROL == roles.ID_ROL);
                if (_roles == null)
                {
                    return "No se encontró el Rol";
                }
                _roles.ID_ROL = roles.ID_ROL;
                _roles.NOMBRE_ROL = roles.NOMBRE_ROL;
                _roles.ACTIVO = roles.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del Rol: " + roles.NOMBRE_ROL;
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
                ROLE _roles = DBHotel.ROLES.FirstOrDefault(t => t.ID_ROL == roles.ID_ROL);
                if (_roles == null)
                {
                    return "No se encontró el Rol";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.ROLES.Remove(_roles);
                DBHotel.SaveChanges();
                return "Se eliminó el Rol: " + _roles.NOMBRE_ROL;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}