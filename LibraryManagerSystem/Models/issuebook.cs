//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagerSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class issuebook
    {
        public int id { get; set; }
        public string member_id { get; set; }
        public string name_member { get; set; }
        public string book_id { get; set; }
        public Nullable<System.DateTime> issuedate { get; set; }
        public Nullable<System.DateTime> returndate { get; set; }
        public string status { get; set; }
        public string book_name { get; set; }
    }
}
