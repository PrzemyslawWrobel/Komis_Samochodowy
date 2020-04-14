﻿// <auto-generated />
using KomisSamochodowy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KomisSamochodowy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200414113705_SamochodZmianaModeluDanych")]
    partial class SamochodZmianaModeluDanych
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KomisSamochodowy.Models.Samochod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cena");

                    b.Property<bool>("JestSamochodemTygodnia");

                    b.Property<bool>("JestWCentrali");

                    b.Property<bool>("JestWcentrali");

                    b.Property<string>("Marka");

                    b.Property<string>("MiniaturkaUrl");

                    b.Property<string>("Moc");

                    b.Property<string>("Model");

                    b.Property<string>("Opis");

                    b.Property<string>("Pojemnosc");

                    b.Property<string>("Przebieg");

                    b.Property<string>("RodzajPaliwa");

                    b.Property<int>("RokProdukcji");

                    b.Property<string>("ZdjecieUrl");

                    b.HasKey("Id");

                    b.ToTable("Samochody");
                });
#pragma warning restore 612, 618
        }
    }
}
