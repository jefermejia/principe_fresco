﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diseno
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class principeFrescoEntities : DbContext
    {
        public principeFrescoEntities()
            : base("name=principeFrescoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Coleccion> Coleccions { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<Evento> Eventoes { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<PrendaUSada> PrendaUSadas { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Tienda> Tiendas { get; set; }
        public virtual DbSet<Transaccion> Transaccions { get; set; }
    }
}
