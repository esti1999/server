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
    
    public partial class assisted_availability
    {
        public int code_availability_assisted { get; set; }
        public int code_availability { get; set; }
        public string id_assisted { get; set; }
    
        public virtual availability availability { get; set; }
        public virtual assisted assisted { get; set; }
    }
}
