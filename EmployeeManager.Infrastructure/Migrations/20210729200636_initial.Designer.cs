﻿// <auto-generated />
using System;
using EmployeeManager.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManager.Infrastructure.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20210729200636_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManager.Core.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("591d3ba4-420a-43c8-b571-74b27b613dfd"),
                            Name = "Engineering"
                        },
                        new
                        {
                            Id = new Guid("87f36f84-c487-471b-bbe0-54fb129b1e31"),
                            Name = "Finance"
                        },
                        new
                        {
                            Id = new Guid("317cfb35-436a-419a-bc13-1c58903d76b9"),
                            Name = "Human Resource"
                        },
                        new
                        {
                            Id = new Guid("31708bbc-d83a-423e-8252-acc2fda9c3bd"),
                            Name = "Maintainence"
                        });
                });

            modelBuilder.Entity("EmployeeManager.Core.Employee", b =>
                {
                    b.Property<int>("EmployeeNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Department")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeNumber");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeNumber = 1,
                            Address = "23 Fox lane London SE15 9PL",
                            City = "London",
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = new Guid("4ee7275d-d469-4330-86df-79f6c847107b"),
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            EmployeeNumber = 2,
                            Address = "23 Fox lane London SE15 9PL",
                            City = "London",
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = new Guid("7e1243e6-a5b8-4db6-b915-74f8200ae681"),
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            EmployeeNumber = 3,
                            Address = "23 Fox lane London SE15 9PL",
                            City = "London",
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = new Guid("f0f89314-82a2-441b-b38e-553047987667"),
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            EmployeeNumber = 4,
                            Address = "23 Fox lane London SE15 9PL",
                            City = "London",
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = new Guid("38782d43-4589-47fd-8b71-28d8ec6c8e67"),
                            FirstName = "John",
                            LastName = "Doe"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
