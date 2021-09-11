﻿// <auto-generated />
using System;
using EntityFramework.Config.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Config.Migrations.SmPedidosDb
{
    [DbContext(typeof(SmPedidosDbContext))]
    partial class SmPedidosDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressCustomers", b =>
                {
                    b.Property<long>("AdressesId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomersId")
                        .HasColumnType("bigint");

                    b.HasKey("AdressesId", "CustomersId");

                    b.HasIndex("CustomersId");

                    b.ToTable("AddressCustomers");
                });

            modelBuilder.Entity("AddressUser", b =>
                {
                    b.Property<long>("AdressesId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsersId")
                        .HasColumnType("bigint");

                    b.HasKey("AdressesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AddressUser");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<long?>("PeopleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TenentId")
                        .HasColumnType("bigint");

                    b.Property<int>("TypeOfAddress")
                        .HasColumnType("int");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId");

                    b.HasIndex("TenentId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<long>("TenentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TenentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Customers", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdentityUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("TenentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Establishment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TenentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("TenentId");

                    b.HasIndex("UserId");

                    b.ToTable("Establishment");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CustomersId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("EstablishmentId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<long>("TenentId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("EstablishmentId");

                    b.HasIndex("TenentId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.People", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Document")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("TenentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Un")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TenentId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Telephone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRegistration")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Inactivated")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PeopleId")
                        .HasColumnType("bigint");

                    b.Property<int>("PhoneType")
                        .HasColumnType("int");

                    b.Property<long?>("UserChangeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PeopleId");

                    b.ToTable("Telephones");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdentityUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("TenentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AddressCustomers", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.Address", null)
                        .WithMany()
                        .HasForeignKey("AdressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Registrations.Customers", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AddressUser", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.Address", null)
                        .WithMany()
                        .HasForeignKey("AdressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Registrations.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Address", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.People", null)
                        .WithMany("Addresses")
                        .HasForeignKey("PeopleId");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Establishment", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.Address", "Address")
                        .WithOne("Establishment")
                        .HasForeignKey("Domain.Entity.Registrations.Establishment", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Registrations.User", null)
                        .WithMany("Establishments")
                        .HasForeignKey("UserId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Order", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Registrations.Establishment", "Establishment")
                        .WithMany()
                        .HasForeignKey("EstablishmentId");

                    b.Navigation("Customers");

                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.OrderItem", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entity.Registrations.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Product", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Telephone", b =>
                {
                    b.HasOne("Domain.Entity.Registrations.People", null)
                        .WithMany("Phones")
                        .HasForeignKey("PeopleId");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Address", b =>
                {
                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.People", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Phones");
                });

            modelBuilder.Entity("Domain.Entity.Registrations.User", b =>
                {
                    b.Navigation("Establishments");
                });
#pragma warning restore 612, 618
        }
    }
}
