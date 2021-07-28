﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_Assignment_2_To_Dos.Data.Context;

namespace Web_Assignment_2_To_Dos.Migrations
{
    [DbContext(typeof(To_DoContext))]
    [Migration("20210728014200_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Web_Assignment_2_To_Dos.Data.To_Do", b =>
                {
                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Done")
                        .HasColumnType("INTEGER");

                    b.Property<string>("To_DoItem")
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("EntryDate");

                    b.ToTable("To_Dos");
                });
#pragma warning restore 612, 618
        }
    }
}