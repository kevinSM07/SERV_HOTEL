using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Servicios_18_20.Models;

namespace Servicios_18_20.Clases.HOTEL
{
    public class clsFactura
    {
        public FACTURA factura { get; set; }
        private DBHOTELEntities4 DBHotel = new DBHOTELEntities4();


        public int GrabarFactura()
        {
            factura.FECHA = DateTime.Now;
            DBHotel.FACTURAs.Add(factura);
            DBHotel.SaveChanges();

            return factura.ID_FACTURA;
        }
   
    }
}