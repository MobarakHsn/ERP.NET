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
    
    public partial class Order
    {
        public int id { get; set; }
        public int customer_id { get; set; }
        public string order_description { get; set; }
        public Nullable<System.DateTime> order_made { get; set; }
        public Nullable<int> total_amount { get; set; }
        public Nullable<System.DateTime> delivered_on { get; set; }
        public string type { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}