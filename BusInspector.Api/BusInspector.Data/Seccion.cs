//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusInspector.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seccion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string nota { get; set; }
        public Nullable<System.DateTime> fechaBaja { get; set; }
        public Nullable<int> CodParada { get; set; }
        public Nullable<int> CodInspector { get; set; }
        public Nullable<decimal> Latitud { get; set; }
        public Nullable<decimal> Longitud { get; set; }
    }
}
