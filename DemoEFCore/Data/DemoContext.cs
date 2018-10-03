using DemoEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Evento>()
                .Property(c => c.Id)
                .HasColumnName("EventoID");

            modelBuilder.Entity<Evento>()
                .HasKey(c => c.Id);

            modelBuilder.Entity<Evento>()
                .Property(c => c.Descricao)
                .HasMaxLength(500)
                .HasColumnType("varchar(500)");

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}
