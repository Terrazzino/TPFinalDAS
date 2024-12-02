using Microsoft.EntityFrameworkCore;
using Modelo.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<ProductoImportado> ProductosImportados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
      //  public DbSet<DetalleFactura> DetallesFacturas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDb; Initial Catalog=TPFinalTiendaMinoristaDB; Integrated Security=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoImportado>()
                .ToTable("ProductoImportado")
                .HasBaseType<Producto>();

            modelBuilder.Entity<Producto>()
                .HasOne(p => p.CategoriaDelProducto);
             //   .WithMany(c => c.Productos)
              //  .HasForeignKey(p => p.CategoriaId);
            modelBuilder.Entity<Producto>().Ignore(Producto => Producto.DetalleFactura);

            modelBuilder.Entity<Proveedor>()
                .HasMany(p => p.Productos)
                .WithMany();

            modelBuilder.Entity<Factura>()
                .HasOne(f => f.ClienteDeFactura)
                .WithMany(c => c.FacturasDeCliente);

            modelBuilder.Entity<Factura>()
                .HasMany(f => f.DetallesDeFactura)
                .WithOne();

            modelBuilder.Entity<DetalleFactura>().Ignore(d => d.Subtotal);
        }

    }
}