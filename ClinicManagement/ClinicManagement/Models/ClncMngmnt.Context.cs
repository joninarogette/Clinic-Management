﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbClinicManagementEntities : DbContext
    {
        public dbClinicManagementEntities()
            : base("name=dbClinicManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<MedCheckDetail> MedCheckDetails { get; set; }
        public virtual DbSet<MedCheckHeader> MedCheckHeaders { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PCollege> PColleges { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
    }
}
