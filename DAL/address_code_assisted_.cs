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
    
    public partial class address_code_assisted_
    {
        public int id { get; set; }
        public int code_address { get; set; }
        public int code_assisted { get; set; }
    
        public virtual address address { get; set; }
        public virtual Personal_Information_Assisted_ Personal_Information_Assisted_ { get; set; }
    }
}
