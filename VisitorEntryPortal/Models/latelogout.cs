//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisitorEntryPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class latelogout
    {
        public int id { get; set; }
        public Nullable<int> empserviceid { get; set; }
        public Nullable<int> modeoftransport { get; set; }
        public string withwhom { get; set; }
        public string vehiclenumber { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> created_by { get; set; }
        public Nullable<long> modified_by { get; set; }
    
        public virtual employeeservice employeeservice { get; set; }
    }
}
