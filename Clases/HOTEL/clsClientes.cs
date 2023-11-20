using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsClientes
    {
        // using Newtonsoft.Json;
        // [JsonIgnore]
        public CLIENTE cliente { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();

        public List<CLIENTE> ListarClientes()
        {
            return DBHotel.CLIENTES
                          .Where(t => t.ACTIVO == true)
                          .OrderBy(t => t.ID_CLIENTE)
                          .ToList();
        }

        //Método consultar
        public CLIENTE Consultar(string documento)
        {
            return DBHotel.CLIENTES.FirstOrDefault(t => t.DOCUMENTO == documento);
        }
        //Método de insertar
        public string Insertar()
        {
            try
            {
                DBHotel.CLIENTES.Add(cliente);
                DBHotel.SaveChanges();
                return "Se insertó el cliente: " + cliente.NOMBRE + " en la base de datos";
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
                CLIENTE _cliente = DBHotel.CLIENTES.FirstOrDefault(t => t.DOCUMENTO == cliente.DOCUMENTO);
                if (_cliente == null)
                {
                    return "No se encontró el tipo de producto";
                }
                _cliente.DOCUMENTO = cliente.DOCUMENTO;
                _cliente.NOMBRE = cliente.NOMBRE;
                _cliente.APELLIDO = cliente.APELLIDO;
                _cliente.DIRECCION = cliente.DIRECCION;
                _cliente.TELEFONO = cliente.TELEFONO;
                _cliente.CORREO_ELECTRONICO = cliente.CORREO_ELECTRONICO;
                _cliente.ID_TIPO_CLIENTE = cliente.ID_TIPO_CLIENTE;
                _cliente.CHECK_IN = cliente.CHECK_IN;
                _cliente.CHECK_OUT = cliente.CHECK_OUT;
                _cliente.ACTIVO = cliente.ACTIVO;

                //Guarda los datos en la base de datos
                DBHotel.SaveChanges();
                return "Se actualizó la información del cliente: " + cliente.NOMBRE;
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
                CLIENTE _cliente = DBHotel.CLIENTES.FirstOrDefault(t => t.DOCUMENTO == cliente.DOCUMENTO);
                if (_cliente == null)
                {
                    return "No se encontró el cliente";
                }
                //Se elimina (Remueve) de la base de datos
                DBHotel.CLIENTES.Remove(_cliente);
                DBHotel.SaveChanges();
                return "Se eliminó el cliente: " + _cliente.NOMBRE;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}