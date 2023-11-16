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
    
    public partial class HABITACIONE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HABITACIONE()
        {
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
            this.RESERVAS = new HashSet<RESERVA>();
        }
    
        public int NUMERO_HABITACION { get; set; }
        public Nullable<int> ID_TIPO_HABITACION { get; set; }
        public Nullable<double> TARIFA_NOCHE { get; set; }
        public Nullable<bool> DISPONIBILIDAD { get; set; }
        public Nullable<int> ID_SERVICIOS_ADICIONALES { get; set; }
        public Nullable<bool> ACTIVO { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }

        [JsonIgnore]
        public virtual HABITACIONES_SERVICIOS HABITACIONES_SERVICIOS { get; set; }

        [JsonIgnore]
        public virtual TIPO_HABITACION TIPO_HABITACION { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVAS { get; set; }
    }
}
