﻿// <auto-generated />
using AeroLinea_Futuro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AeroLinea_Futuro.Migrations.Vuelos
{
    [DbContext(typeof(VuelosContext))]
    [Migration("20200321001233_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AeroLinea_Futuro.Models.Vuelos", b =>
                {
                    b.Property<int>("Id_Vuelos")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Escala")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Tanda")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("Id_Vuelos");

                    b.ToTable("Vuelos");
                });
#pragma warning restore 612, 618
        }
    }
}
