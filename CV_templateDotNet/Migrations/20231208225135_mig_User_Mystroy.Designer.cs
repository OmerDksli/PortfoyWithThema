﻿// <auto-generated />
using System;
using CV_templateDotNet.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CV_templateDotNet.Migrations
{
    [DbContext(typeof(CVtemplateDotNetContext))]
    [Migration("20231208225135_mig_User_Mystroy")]
    partial class mig_User_Mystroy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CV_templateDotNet.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("FieldOfStudy")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nchar(200)");

                    b.Property<DateTime>("GraduationYear")
                        .HasColumnType("date");

                    b.Property<string>("SchoolDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nchar(200)");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.ImagePath", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CvImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PojectId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PojectId");

                    b.HasIndex("UserId");

                    b.ToTable("ImagePaths");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.NetworkReferances", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("char(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("char(10)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.HasKey("Id");

                    b.ToTable("NetworkReferances");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nchar(200)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("GithubUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("ProjectType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(20)");

                    b.Property<string>("UsedTeknologies")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<byte>("SkillLevel")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nchar(200)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("char(256)");

                    b.Property<string>("MyStory")
                        .HasColumnType("nchar(500)");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("char(10)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.ImagePath", b =>
                {
                    b.HasOne("CV_templateDotNet.Models.Project", "Project")
                        .WithMany("Images")
                        .HasForeignKey("PojectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CV_templateDotNet.Models.User", "User")
                        .WithMany("ProfilImage")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.Project", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("CV_templateDotNet.Models.User", b =>
                {
                    b.Navigation("ProfilImage");
                });
#pragma warning restore 612, 618
        }
    }
}
