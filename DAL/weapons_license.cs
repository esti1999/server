//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class weapons_license
    {
        public int code_volunteer { get; set; }
        public int code_license { get; set; }
        public string Valid_license { get; set; }
        public string Knowledge_in { get; set; }
    
        public virtual Personal_Information_vo_ Personal_Information_vo_ { get; set; }
        public virtual Weapons_license_code_ Weapons_license_code_ { get; set; }
    }
}
