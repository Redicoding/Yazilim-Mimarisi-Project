﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yazilim_Mimarisi_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YazilimMimarisiEntities : DbContext
    {
        public YazilimMimarisiEntities()
            : base("name=YazilimMimarisiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Tbl_DIYETISYEN> Tbl_DIYETISYEN { get; set; }
        public virtual DbSet<Tbl_DIYETLER> Tbl_DIYETLER { get; set; }
        public virtual DbSet<Tbl_HASTA> Tbl_HASTA { get; set; }
        public virtual DbSet<Tbl_HASTALIK> Tbl_HASTALIK { get; set; }
        public virtual DbSet<Tbl_PROGRAM> Tbl_PROGRAM { get; set; }
        public virtual DbSet<Tbl_Admin> Tbl_Admin { get; set; }
    }
}
