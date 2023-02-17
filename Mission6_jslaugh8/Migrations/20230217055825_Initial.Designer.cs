﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_jslaugh8.Models;

namespace Mission6_jslaugh8.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20230217055825_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_jslaugh8.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 1,
                            Director = "Baz Luhrmann",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "The Great Gatsby",
                            Year = 2013
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 2,
                            Director = "Lasse Hallström",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG",
                            Title = "A Dog's Purpose",
                            Year = 2017
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Director = "Andrew Stanton",
                            Edited = true,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "John Carter",
                            Year = 2012
                        });
                });

            modelBuilder.Entity("Mission6_jslaugh8.Models.MovieCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Romance/Drama"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Family/Drama"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Sci-fi/Action"
                        });
                });

            modelBuilder.Entity("Mission6_jslaugh8.Models.Movie", b =>
                {
                    b.HasOne("Mission6_jslaugh8.Models.MovieCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}