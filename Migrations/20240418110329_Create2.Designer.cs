﻿// <auto-generated />
using EntityTaskOne.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityTaskOne.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20240418110329_Create2")]
    partial class Create2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("EntityTaskOne.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Blog");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "yousef",
                            Url = "www.google.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
