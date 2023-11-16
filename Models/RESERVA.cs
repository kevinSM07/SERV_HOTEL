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
    
    public partial class RESERVA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVA()
        {
            this.FACTURAs = new HashSet<FACTURA>();
        }
    
        public int ID_RESERVA { get; set; }
        public Nullable<int> ID_CLIENTE { get; set; }
        public string NOMBRE { get; set; }
        public string TELEFONO { get; set; }
        public Nullable<int> CANTIDAD_C { get; set; }
        public Nullable<int> ID_SEDE { get; set; }
        public Nullable<int> NUMERO_HABITACION { get; set; }
        public Nullable<int> ID_SERVICIO { get; set; }
        public Nullable<int> ID_CANCELACION { get; set; }
        public Nullable<int> ID_EVENTO { get; set; }
        public Nullable<System.DateTime> FECHA_ENTRADA { get; set; }
        public Nullable<System.DateTime> FECHA_SALIDA { get; set; }
        public Nullable<int> ID_ENTRADA_SALIDA { get; set; }
        public Nullable<double> PRECIO_RESERVA { get; set; }
        public Nullable<bool> ESTADO_RESERVA { get; set; }

        [JsonIgnore]
        public virtual CANCELACIONE CANCELACIONE { get; set; }

        [JsonIgnore]
        public virtual CLIENTE CLIENTE { get; set; }

        [JsonIgnore]
        public virtual EVENTO EVENTO { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA> FACTURAs { get; set; }

        [JsonIgnore]
        public virtual HABITACIONE HABITACIONE { get; set; }

        [JsonIgnore]
        public virtual REGISTRO_ENTRADA_SALIDA REGISTRO_ENTRADA_SALIDA { get; set; }

        [JsonIgnore]
        public virtual SEDE SEDE { get; set; }

        [JsonIgnore]
        public virtual SERVICIO SERVICIO { get; set; }
    }
}
