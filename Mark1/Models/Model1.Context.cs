﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mark1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ASTOR2Entities : DbContext
    {
        public ASTOR2Entities()
            : base("name=ASTOR2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kullanici_Bilgi> Kullanici_Bilgi { get; set; }
        public virtual DbSet<TB_Araçlar> TB_Araçlar { get; set; }
        public virtual DbSet<TB_Müsteriler> TB_Müsteriler { get; set; }
        public virtual DbSet<TB_Personel> TB_Personel { get; set; }
        public virtual DbSet<TB_Seferler> TB_Seferler { get; set; }
        public virtual DbSet<TB_şoförler> TB_şoförler { get; set; }
    }
}
