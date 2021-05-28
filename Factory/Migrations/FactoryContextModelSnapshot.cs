﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SillyFactory.Models;

namespace Factory.Migrations
{
    [DbContext(typeof(FactoryContext))]
    partial class FactoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SillyFactory.Models.Engineer", b =>
                {
                    b.Property<int>("EngineerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CertDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CertExp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CertNum")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EngineerId");

                    b.ToTable("Engineers");
                });

            modelBuilder.Entity("SillyFactory.Models.EngineerMachine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EngineerId")
                        .HasColumnType("int");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EngineerId");

                    b.HasIndex("MachineId");

                    b.ToTable("EngineerMachine");
                });

            modelBuilder.Entity("SillyFactory.Models.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Dept")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("InstDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Make")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Model")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Serial")
                        .HasColumnType("int");

                    b.HasKey("MachineId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("SillyFactory.Models.EngineerMachine", b =>
                {
                    b.HasOne("SillyFactory.Models.Engineer", "Engineer")
                        .WithMany("EMJoinEntities")
                        .HasForeignKey("EngineerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SillyFactory.Models.Machine", "Machine")
                        .WithMany("EMJoinEntities")
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Engineer");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("SillyFactory.Models.Engineer", b =>
                {
                    b.Navigation("EMJoinEntities");
                });

            modelBuilder.Entity("SillyFactory.Models.Machine", b =>
                {
                    b.Navigation("EMJoinEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
