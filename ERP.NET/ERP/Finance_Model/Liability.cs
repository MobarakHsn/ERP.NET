//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Finance_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Liability
    {
        public int id { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<int> manager_id { get; set; }
        public string type { get; set; }
    
        public virtual User User { get; set; }
    }
}
