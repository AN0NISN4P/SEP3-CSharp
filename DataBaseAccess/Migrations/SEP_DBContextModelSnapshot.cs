﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using DataBaseAccess;

namespace SEP3_DB_Server.Migrations
{
    [DbContext(typeof(SEP_DBContext))]
    partial class SEP_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Entities.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("ItemName")
                        .HasColumnType("text");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.Property<double>("Width")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Entities.Models.ItemLocationDB", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<string>("LocationId")
                        .HasColumnType("text");

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.HasKey("ItemId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("ItemLocationsDB");
                });

            modelBuilder.Entity("Entities.Models.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("SEP3_WebServerClient.Models.Spike", b =>
                {
                    b.Property<string>("SpikeName")
                        .HasColumnType("text");

                    b.HasKey("SpikeName");

                    b.ToTable("Spikes");
                });

            modelBuilder.Entity("Entities.Models.ItemLocationDB", b =>
                {
                    b.HasOne("Entities.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
