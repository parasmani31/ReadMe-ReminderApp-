//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UniqueString { get; set; }
        public System.DateTime LastOnline { get; set; }
        public string RemindMeVersion { get; set; }
        public Nullable<int> ActiveReminders { get; set; }
        public Nullable<int> DisabledReminders { get; set; }
        public Nullable<int> DeletedReminders { get; set; }
        public Nullable<int> ArchivedReminders { get; set; }
        public Nullable<int> TotalReminders { get; set; }
        public int SignIns { get; set; }
        public Nullable<int> Material { get; set; }
        public int AutoUpdate { get; set; }
    }
}
