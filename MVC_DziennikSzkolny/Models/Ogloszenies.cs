//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_DziennikSzkolny.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ogloszenies
    {
        public int ogloszenieID { get; set; }
        public string temat { get; set; }
        public string tresc { get; set; }
        public System.DateTime data_wystawienia { get; set; }
        public int nauczycielID { get; set; }
        public int klasaID { get; set; }
    
        public virtual Klasas Klasas { get; set; }
        public virtual Nauczyciels Nauczyciels { get; set; }
    }
}
