//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusInspector.Dal
{
    using System;
    using System.Collections.Generic;

    public partial class Inspector
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspector()
        {
            this.Inspeccions = new HashSet<Inspeccion>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> dni { get; set; }
        public Nullable<decimal> legajo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspeccion> Inspeccions { get; set; }
    }
}
