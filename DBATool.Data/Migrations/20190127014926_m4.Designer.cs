﻿// <auto-generated />
using System;
using DBATool.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBATool.Data.Migrations
{
    [DbContext(typeof(DBAToolDbContext))]
    [Migration("20190127014926_m4")]
    partial class m4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBATool.Data.Models.Database", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumberOfUsers");

                    b.Property<int?>("ServerId");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.HasIndex("ServerId");

                    b.ToTable("Databases");
                });

            modelBuilder.Entity("DBATool.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DBATool.Data.Models.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CpuCore");

                    b.Property<float>("CpuSpeed");

                    b.Property<string>("ImageUrl");

                    b.Property<int>("Memory");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<int?>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Servers");
                });

            modelBuilder.Entity("DBATool.Data.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("DBATool.Data.Models.Database", b =>
                {
                    b.HasOne("DBATool.Data.Models.Server")
                        .WithMany("Databases")
                        .HasForeignKey("ServerId");
                });

            modelBuilder.Entity("DBATool.Data.Models.Server", b =>
                {
                    b.HasOne("DBATool.Data.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
