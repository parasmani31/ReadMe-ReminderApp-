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
    
    public partial class UserThemes
    {
        public int Id { get; set; }
        public long NormalPrimary { get; set; }
        public long DarkPrimary { get; set; }
        public long LightPrimary { get; set; }
        public long Accent { get; set; }
        public long TextShade { get; set; }
        public long Mode { get; set; }
        public string ThemeName { get; set; }
    }
}
