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
    
    public partial class Bank
    {
        public int id { get; set; }
        public string name { get; set; }
        public string holder_name { get; set; }
        public string account_no { get; set; }
        public Nullable<double> balance { get; set; }
        public Nullable<int> manager_id { get; set; }
    }
}
