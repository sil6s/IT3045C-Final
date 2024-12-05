﻿// <auto-generated />
using System;
using IT3045C_Final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IT3045C_Final.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("IT3045C_Final.Models.BreakfastFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BreakfastYN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Carbs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FruitsOrVeggies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Protein")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamMemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamMemberId");

                    b.ToTable("BreakfastFood");
                });

            modelBuilder.Entity("IT3045C_Final.Models.Hobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Academic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artistic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Athletic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyYN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Musical")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamMemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamMemberId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("IT3045C_Final.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PetType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamMemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamMemberId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("IT3045C_Final.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("IT3045C_Final.Models.BreakfastFood", b =>
                {
                    b.HasOne("IT3045C_Final.Models.TeamMember", "TeamMember")
                        .WithMany("BreakfastFoods")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("IT3045C_Final.Models.Hobby", b =>
                {
                    b.HasOne("IT3045C_Final.Models.TeamMember", "TeamMember")
                        .WithMany("Hobbies")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("IT3045C_Final.Models.Pet", b =>
                {
                    b.HasOne("IT3045C_Final.Models.TeamMember", "TeamMember")
                        .WithMany("Pets")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("IT3045C_Final.Models.TeamMember", b =>
                {
                    b.Navigation("BreakfastFoods");

                    b.Navigation("Hobbies");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
