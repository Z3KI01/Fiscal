using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal.Classe
{
    public class ConexaoBD
    {
        public string ConnectionString()
        {
            return $"DataSource=localhost;Database=C:\\Users\\ezequ\\OneDrive\\Documentos\\Des\\Fiscal\\Fiscal\\BD\\BASESGMASTER.FDB;Port=3045;User=SYSDBA;Password=masterkey;Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000";
        }
        public class SgTable : DbContext
        {
            public DbSet<Emitente> emitente { get; set; }
            public DbSet<dadostContabilista> contabilista { get; set; }
            public DbSet<Fornecedores> fornecedor { get; set; }
            public DbSet<Estoque> produto { get; set; }
            public DbSet<Compra> compra { get; set; } 
            public DbSet<Cliente> clientes { get; set; } 
            public DbSet<VendaNfe> vendaNfe { get; set; } 
            public DbSet<VendaNfce> vendaNfce { get; set; } 

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                new EmitenteEntityTypeConfiguration().Configure(modelBuilder.Entity<Emitente>());
                base.OnModelCreating(modelBuilder);
                new dadostContabilistaEntityTypeConfiguration().Configure(modelBuilder.Entity<dadostContabilista>());
                base.OnModelCreating(modelBuilder);
                new FornecedoresEntityTypeConfiguration().Configure(modelBuilder.Entity<Fornecedores>());
                base.OnModelCreating(modelBuilder);
                new EstoqueEntityTypeConfiguration().Configure(modelBuilder.Entity<Estoque>());
                base.OnModelCreating(modelBuilder);
                new CompraEntityTypeConfiguration().Configure(modelBuilder.Entity<Compra>());
                base.OnModelCreating(modelBuilder);
                new ClienteEntityTypeConfiguration().Configure(modelBuilder.Entity<Cliente>());
                base.OnModelCreating(modelBuilder);
                new VendaNfeEntityTypeConfiguration().Configure(modelBuilder.Entity<VendaNfe>());
                base.OnModelCreating(modelBuilder);
                new VendaNfceEntityTypeConfiguration().Configure(modelBuilder.Entity<VendaNfce>());
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseFirebird("DataSource=localhost;Database=C:\\Users\\ezequ\\OneDrive\\Documentos\\Des\\Fiscal\\Fiscal\\BD\\BASESGMASTER.FDB;Port=3050;User=SYSDBA;Password=masterkey" +
                            ";Charset=UTF8;Dialect=3;Connection lifetime=15;PacketSize=8192;ServerType=0;Unicode=True;Max Pool Size=1000");
            }


        }
    }
}
