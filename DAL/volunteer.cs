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
    
    public partial class volunteer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public volunteer()
        {
            this.availability_volunteer = new HashSet<availability_volunteer>();
            this.car_license_volunteer = new HashSet<car_license_volunteer>();
            this.training_volunteer = new HashSet<training_volunteer>();
            this.volunteer_domain = new HashSet<volunteer_domain>();
            this.volunteer_language = new HashSet<volunteer_language>();
            this.weapons_license_volunteer = new HashSet<weapons_license_volunteer>();
        }
    
        public string id_volunteer { get; set; }
        public string firstName_volunteer { get; set; }
        public string lastName_volunteer { get; set; }
        public System.DateTime date_of_birth { get; set; }
        public int code_gender { get; set; }
        public int code_status { get; set; }
        public int code_city { get; set; }
        public string street { get; set; }
        public string postal_code { get; set; }
        public int house_number { get; set; }
        public int bulding_number { get; set; }
        public int number_floor { get; set; }
        public string e_mail { get; set; }
        public int code_service { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> release_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<availability_volunteer> availability_volunteer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<car_license_volunteer> car_license_volunteer { get; set; }
        public virtual services services { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<training_volunteer> training_volunteer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<volunteer_domain> volunteer_domain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<volunteer_language> volunteer_language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<weapons_license_volunteer> weapons_license_volunteer { get; set; }
<<<<<<< HEAD
=======
        public virtual city city { get; set; }
        public virtual gender gender { get; set; }
        public virtual personal_status personal_status { get; set; }
>>>>>>> 8052e0d920678382b409a855a2616810babf5883
    }
}
