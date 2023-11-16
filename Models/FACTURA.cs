//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios_18_20.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURA()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
        }
    
        public int ID_FACTURA { get; set; }
        public Nullable<int> ID_RESERVA { get; set; }
        public Nullable<int> ID_SEDE { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public Nullable<int> ID_MODO_PAGO { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<bool> ACTIVO { get; set; }

        [JsonIgnore]
        public virtual CLIENTE CLIENTE { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }

        [JsonIgnore]
        public virtual RESERVA RESERVA { get; set; }

        [JsonIgnore]
        public virtual MODO_PAGO MODO_PAGO { get; set; }

        [JsonIgnore]
        public virtual SEDE SEDE { get; set; }
    }
}