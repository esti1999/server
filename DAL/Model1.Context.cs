﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Progect_lEntities : DbContext
    {
        public Progect_lEntities()
            : base("name=Progect_lEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assisted_domain> assisted_domain { get; set; }
        public virtual DbSet<assisted_language> assisted_language { get; set; }
        public virtual DbSet<availability> availability { get; set; }
        public virtual DbSet<availability_volunteer> availability_volunteer { get; set; }
        public virtual DbSet<car_license> car_license { get; set; }
        public virtual DbSet<car_license_volunteer> car_license_volunteer { get; set; }
        public virtual DbSet<city> city { get; set; }
        public virtual DbSet<domain> domain { get; set; }
        public virtual DbSet<gender> gender { get; set; }
        public virtual DbSet<language> language { get; set; }
        public virtual DbSet<personal_status> personal_status { get; set; }
        public virtual DbSet<services> services { get; set; }
        public virtual DbSet<training> training { get; set; }
        public virtual DbSet<training_volunteer> training_volunteer { get; set; }
        public virtual DbSet<volunteer> volunteer { get; set; }
        public virtual DbSet<volunteer_domain> volunteer_domain { get; set; }
        public virtual DbSet<volunteer_language> volunteer_language { get; set; }
        public virtual DbSet<volunteering_domain> volunteering_domain { get; set; }
        public virtual DbSet<weapons_license> weapons_license { get; set; }
        public virtual DbSet<weapons_license_volunteer> weapons_license_volunteer { get; set; }
<<<<<<< HEAD
=======
        public virtual DbSet<services> services { get; set; }
        public virtual DbSet<assisted_language> assisted_language { get; set; }
        public virtual DbSet<volunteer_language> volunteer_language { get; set; }
        public virtual DbSet<assisted_availability> assisted_availability { get; set; }
        public virtual DbSet<assisted> assisted { get; set; }
        public virtual DbSet<volunteer> volunteer { get; set; }
>>>>>>> 8052e0d920678382b409a855a2616810babf5883
    }
}
