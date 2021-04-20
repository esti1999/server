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
    
    public partial class assisted
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public assisted()
        {
            this.assisted_availability = new HashSet<assisted_availability>();
            this.assisted_domain = new HashSet<assisted_domain>();
            this.assisted_language = new HashSet<assisted_language>();
        }
    
        public string id_assisted { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public System.DateTime date_birth { get; set; }
        public int code_status { get; set; }
        public int code_gender { get; set; }
        public int code_city { get; set; }
        public string street { get; set; }
        public int number_house { get; set; }
        public int number_building { get; set; }
        public int number_floor { get; set; }
        public string postal_code { get; set; }
        public string e_mail { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assisted_availability> assisted_availability { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assisted_domain> assisted_domain { get; set; }
        public virtual gender gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<assisted_language> assisted_language { get; set; }
        public virtual personal_status personal_status { get; set; }
    }
}
