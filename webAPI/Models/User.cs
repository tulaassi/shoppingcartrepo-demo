//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ProfileID { get; set; }
        public string FullName { get; set; }
        public string EmailID { get; set; }
        public string MobileNumber { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
    }
}
