//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPAAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserActivityMenuHit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ModuleId { get; set; }
        public string Key { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public int Hit { get; set; }
        public System.DateTime DateLastHit { get; set; }
    }
}
