﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentApplication.EF;

#nullable disable

namespace StudentApplication.EF.Migrations
{
    [DbContext(typeof(SMDbContext))]
    [Migration("20220616154941_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StudentApplication.Domain.Model.Courses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BeginTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudiesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudiesId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Grades", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GradeValue")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int?>("TestsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentsId");

                    b.HasIndex("TestsId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Schools", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameSchool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int?>("SchoolsId")
                        .HasColumnType("int");

                    b.Property<int?>("StudiesId")
                        .HasColumnType("int");

                    b.Property<int>("StudyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolsId");

                    b.HasIndex("StudiesId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Studies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DateFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateTo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameStudy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studies");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Tests", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("CoursesId")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CoursesId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Courses", b =>
                {
                    b.HasOne("StudentApplication.Domain.Model.Studies", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudiesId");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Grades", b =>
                {
                    b.HasOne("StudentApplication.Domain.Model.Students", null)
                        .WithMany("Grades")
                        .HasForeignKey("StudentsId");

                    b.HasOne("StudentApplication.Domain.Model.Tests", null)
                        .WithMany("Grades")
                        .HasForeignKey("TestsId");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Students", b =>
                {
                    b.HasOne("StudentApplication.Domain.Model.Schools", null)
                        .WithMany("Students")
                        .HasForeignKey("SchoolsId");

                    b.HasOne("StudentApplication.Domain.Model.Studies", null)
                        .WithMany("Students")
                        .HasForeignKey("StudiesId");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Tests", b =>
                {
                    b.HasOne("StudentApplication.Domain.Model.Courses", null)
                        .WithMany("Tests")
                        .HasForeignKey("CoursesId");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Courses", b =>
                {
                    b.Navigation("Tests");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Schools", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Students", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Studies", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentApplication.Domain.Model.Tests", b =>
                {
                    b.Navigation("Grades");
                });
#pragma warning restore 612, 618
        }
    }
}
