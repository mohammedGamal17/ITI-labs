﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School.Models;

#nullable disable

namespace SchoolTest.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20230609082354_m5AddStudentsCourses")]
    partial class m5AddStudentsCourses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("School.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("DeptID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolTest.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolTest.Models.DepartmentsCourses", b =>
                {
                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<int>("CursID")
                        .HasColumnType("int");

                    b.HasKey("DeptID", "CursID");

                    b.HasIndex("CursID");

                    b.ToTable("DepartmentsCourses");
                });

            modelBuilder.Entity("SchoolTest.Models.StudentsCourses", b =>
                {
                    b.Property<int>("StdId")
                        .HasColumnType("int");

                    b.Property<int>("CursID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.HasKey("StdId", "CursID");

                    b.HasIndex("CursID");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.HasOne("School.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolTest.Models.DepartmentsCourses", b =>
                {
                    b.HasOne("SchoolTest.Models.Course", "Course")
                        .WithMany("DepartmentsCousrces")
                        .HasForeignKey("CursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Models.Department", "Department")
                        .WithMany("DepartmentsCousrces")
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolTest.Models.StudentsCourses", b =>
                {
                    b.HasOne("SchoolTest.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CursID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("School.Models.Student", "Student")
                        .WithMany("StudentsCourses")
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("School.Models.Department", b =>
                {
                    b.Navigation("DepartmentsCousrces");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("School.Models.Student", b =>
                {
                    b.Navigation("StudentsCourses");
                });

            modelBuilder.Entity("SchoolTest.Models.Course", b =>
                {
                    b.Navigation("DepartmentsCousrces");
                });
#pragma warning restore 612, 618
        }
    }
}
