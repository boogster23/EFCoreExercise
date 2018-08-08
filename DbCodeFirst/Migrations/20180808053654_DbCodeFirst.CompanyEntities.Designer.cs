﻿// <auto-generated />
using DbCodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DbCodeFirst.Migrations
{
    [DbContext(typeof(CompanyEntities))]
    [Migration("20180808053654_DbCodeFirst.CompanyEntities")]
    partial class DbCodeFirstCompanyEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DbCodeFirst.Department", b =>
                {
                    b.Property<int>("DeptUniqueId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("DeptNo");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("DeptUniqueId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DbCodeFirst.Employee", b =>
                {
                    b.Property<int>("EmpUniqueId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeptUniqueId");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("EmpFirstName")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("EmpLastName")
                        .HasMaxLength(80);

                    b.Property<int>("EmpNo");

                    b.Property<int>("Salary");

                    b.HasKey("EmpUniqueId");

                    b.HasIndex("DeptUniqueId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DbCodeFirst.Employee", b =>
                {
                    b.HasOne("DbCodeFirst.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptUniqueId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
