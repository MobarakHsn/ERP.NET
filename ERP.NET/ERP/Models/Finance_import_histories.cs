//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Finance_import_histories
    {
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string action { get; set; }
        public Nullable<int> employee_id { get; set; }
        public string file { get; set; }
    
        public virtual User User { get; set; }
    }
}
