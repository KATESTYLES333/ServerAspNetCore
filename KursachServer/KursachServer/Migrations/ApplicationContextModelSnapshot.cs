﻿// <auto-generated />
using KursachServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KursachServer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KursachServer.Models.DBModels.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FIO");

                    b.Property<int>("FlatId");

                    b.Property<int>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("FlatId");

                    b.HasIndex("TicketId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.FLat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HouseId");

                    b.Property<string>("Number");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("StreetId");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountTraining");

                    b.Property<decimal>("Price");

                    b.Property<int>("ServiceId");

                    b.Property<int>("TicketTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("TicketTypeId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.TicketType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("TicketTypes");
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.City", b =>
                {
                    b.HasOne("KursachServer.Models.DBModels.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Customer", b =>
                {
                    b.HasOne("KursachServer.Models.DBModels.FLat", "FLat")
                        .WithMany("Customers")
                        .HasForeignKey("FlatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KursachServer.Models.DBModels.Ticket", "Ticket")
                        .WithMany("Customers")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.FLat", b =>
                {
                    b.HasOne("KursachServer.Models.DBModels.House", "House")
                        .WithMany("Flats")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.House", b =>
                {
                    b.HasOne("KursachServer.Models.DBModels.Street", "Street")
                        .WithMany("Houses")
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Street", b =>
                {
                    b.HasOne("KursachServer.Models.DBModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KursachServer.Models.DBModels.Ticket", b =>
                {
                    b.HasOne("KursachServer.Models.DBModels.Service", "Service")
                        .WithMany("Tickets")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KursachServer.Models.DBModels.TicketType", "TicketType")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
