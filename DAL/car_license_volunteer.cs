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
    
    public partial class car_license_volunteer
    {
        public int code_car_license_volunteer { get; set; }
        public int code_car_license { get; set; }
        public string id_volunteer { get; set; }
        public System.DateTime validity { get; set; }
    
        public virtual car_license car_license { get; set; }
        public virtual volunteer volunteer { get; set; }
    }
}