﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P1FinalDbContext;

namespace P1FinalDbContext.Migrations
{
    [DbContext(typeof(P1TestDbContext))]
    [Migration("20210625043424_Ipsummig1")]
    partial class Ipsummig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("P1FinalDbContext.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("Favorite")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("FName");

                    b.Property<string>("Lname")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("LName");

                    b.Property<string>("Member")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CustomerId");

                    b.HasIndex("Favorite");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("P1FinalDbContext.Favorite", b =>
                {
                    b.Property<int>("FavoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Store")
                        .HasColumnType("int");

                    b.HasKey("FavoriteId");

                    b.HasIndex("Store");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("P1FinalDbContext.Inventory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.Property<int?>("QuanStore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("ProductId", "StoreId")
                        .HasName("COMPOSITE");

                    b.HasIndex("StoreId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("P1FinalDbContext.Location", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("State")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("StoreId")
                        .HasName("PK__Location__3B82F10155C9A1FF");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("P1FinalDbContext.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOrder")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("QuanOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("P1FinalDbContext.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal?>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallmoney")
                        .HasDefaultValueSql("((0.00))");

                    b.Property<string>("Size")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Text")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)")
                        .HasDefaultValueSql("('No Item Data Available')");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("P1FinalDbContext.Customer", b =>
                {
                    b.HasOne("P1FinalDbContext.Favorite", "FavoriteNavigation")
                        .WithMany("Customers")
                        .HasForeignKey("Favorite")
                        .HasConstraintName("FK__Customer__Favori__46E78A0C")
                        .IsRequired();

                    b.Navigation("FavoriteNavigation");
                });

            modelBuilder.Entity("P1FinalDbContext.Favorite", b =>
                {
                    b.HasOne("P1FinalDbContext.Location", "StoreNavigation")
                        .WithMany("Favorites")
                        .HasForeignKey("Store")
                        .HasConstraintName("FK__Favorites__Store__3F466844");

                    b.Navigation("StoreNavigation");
                });

            modelBuilder.Entity("P1FinalDbContext.Inventory", b =>
                {
                    b.HasOne("P1FinalDbContext.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Inventory__Produ__4AB81AF0")
                        .IsRequired();

                    b.HasOne("P1FinalDbContext.Location", "Store")
                        .WithMany("Inventories")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__Inventory__Store__49C3F6B7")
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("P1FinalDbContext.Order", b =>
                {
                    b.HasOne("P1FinalDbContext.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK__Orders__Customer__5070F446");

                    b.HasOne("P1FinalDbContext.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Orders__ProductI__4E88ABD4");

                    b.HasOne("P1FinalDbContext.Location", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreId")
                        .HasConstraintName("FK__Orders__StoreId__4F7CD00D");

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("P1FinalDbContext.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("P1FinalDbContext.Favorite", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("P1FinalDbContext.Location", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Inventories");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("P1FinalDbContext.Product", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
