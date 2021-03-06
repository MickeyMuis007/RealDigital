﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RealDigital.Persistence.Context;

namespace RealDigital.Persistence.Migrations
{
    [DbContext(typeof(RealDigitalContext))]
    partial class RealDigitalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RealDigital.Domain.AggregateModels.ContactAggregate.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e1"),
                            Email = "michael@mah",
                            FirstName = "Michael",
                            LastName = "Hendricks",
                            PhoneNo = "0784344321"
                        },
                        new
                        {
                            Id = new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e2"),
                            Email = "jacob@mah",
                            FirstName = "Jacob",
                            LastName = "Collins",
                            PhoneNo = "0784323421"
                        },
                        new
                        {
                            Id = new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e3"),
                            Email = "adam@mah",
                            FirstName = "Adam",
                            LastName = "Antons",
                            PhoneNo = "0784346789"
                        },
                        new
                        {
                            Id = new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e4"),
                            Email = "james@mah",
                            FirstName = "James",
                            LastName = "Barns",
                            PhoneNo = "0732343521"
                        },
                        new
                        {
                            Id = new Guid("f9168c5e-ceb2-4faa-b6bf-329bf39fa1e5"),
                            Email = "tammy@mah",
                            FirstName = "Tammy",
                            LastName = "Micthels",
                            PhoneNo = "0784347654"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
