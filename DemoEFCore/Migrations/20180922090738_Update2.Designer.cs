using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DemoEFCore.Data;

namespace DemoEFCore.Migrations
{
    [DbContext(typeof(DemoContext))]
    [Migration("20180922090738_Update2")]
    partial class Update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoEFCore.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("EventoID");

                    b.Property<DateTime>("Data");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("Gratuito");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });
        }
    }
}
