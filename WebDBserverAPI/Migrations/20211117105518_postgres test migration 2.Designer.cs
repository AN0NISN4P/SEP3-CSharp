﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebDBserverAPI.DataAccess;

namespace SEP3_DB_Server.Migrations
{
    [DbContext(typeof(SEP_DBContext))]
    [Migration("20211117105518_postgres test migration 2")]
    partial class postgrestestmigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebDBserverAPI.Models.Spike", b =>
                {
                    b.Property<string>("SpikeName")
                        .HasColumnType("text");

                    b.HasKey("SpikeName");

                    b.ToTable("Spikes");
                });
#pragma warning restore 612, 618
        }
    }
}
