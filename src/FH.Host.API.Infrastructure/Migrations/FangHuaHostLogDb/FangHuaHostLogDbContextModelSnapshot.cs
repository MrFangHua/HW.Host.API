﻿// <auto-generated />
using System;
using FH.Host.API.Infrastructure.LogDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FH.Host.API.Infrastructure.Migrations.FangHuaHostLogDb
{
    [DbContext(typeof(FangHuaHostLogDbContext))]
    partial class FangHuaHostLogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FH.Host.API.Model.LogEntity.FH_Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Exception")
                        .HasMaxLength(5000);

                    b.Property<string>("Level")
                        .HasMaxLength(50);

                    b.Property<string>("Logger");

                    b.Property<string>("Message")
                        .HasMaxLength(5000);

                    b.Property<int>("Thread");

                    b.HasKey("Id");

                    b.ToTable("FH_Log");
                });
#pragma warning restore 612, 618
        }
    }
}