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
    
    public partial class visitorservice
    {
        public int id { get; set; }
        public Nullable<int> userid { get; set; }
        public short purposeofvisitid { get; set; }
        public System.DateTime intime { get; set; }
        public System.DateTime outtime { get; set; }
        public string whomtomeet { get; set; }
        public Nullable<int> companyid { get; set; }
        public Nullable<int> remarkid { get; set; }
        public System.DateTime created_on { get; set; }
        public Nullable<System.DateTime> modified_on { get; set; }
        public Nullable<long> created_by { get; set; }
        public Nullable<long> modified_by { get; set; }
    
        public virtual comment comment { get; set; }
        public virtual user user { get; set; }
    }
}