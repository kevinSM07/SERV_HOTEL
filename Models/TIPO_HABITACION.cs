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
    
    public partial class TIPO_HABITACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_HABITACION()
        {
            this.HABITACIONES = new HashSet<HABITACIONE>();
        }
    
        public int ID_TIPO_HABITACION { get; set; }
        public string TIPO { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<double> PRECIO { get; set; }
        public Nullable<bool> ACTIVO { get; set; }

        [JsonIgnore]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HABITACIONE> HABITACIONES { get; set; }
    }
}
