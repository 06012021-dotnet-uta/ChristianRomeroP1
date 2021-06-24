using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace P1FinalDbContext
{
    public partial class P1TestDbContext : DbContext
    {
        public P1TestDbContext()
        {
        }

        public P1TestDbContext(DbContextOptions<P1TestDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-NF2VDIE\\SQLEXPRESS01;Database=P1TestDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.Age).HasDefaultValueSql("((0))");

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(64);

                entity.Property(e => e.Fname)
                    .HasMaxLength(30)
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .HasMaxLength(30)
                    .HasColumnName("LName");

                entity.Property(e => e.Mailing).HasMaxLength(100);

                entity.Property(e => e.Member).HasDefaultValueSql("((0))");

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.Username).HasMaxLength(30);

                entity.Property(e => e.Zip).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FavoriteNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.Favorite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer__Favori__5070F446");
            });

            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasOne(d => d.StoreNavigation)
                    .WithMany(p => p.Favorites)
                    .HasForeignKey(d => d.Store)
                    .HasConstraintName("FK__Favorites__Store__3B75D760");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("COMPOSITE");

                entity.ToTable("Inventory");

                entity.Property(e => e.QuanStore).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Produ__47DBAE45");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Store__46E78A0C");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__Location__3B82F101611E40C9");

                entity.ToTable("Location");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(20);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.QuanOrder).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__5812160E");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Orders__ProductI__5629CD9C");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK__Orders__StoreId__571DF1D5");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Make).HasMaxLength(40);

                entity.Property(e => e.Price)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Size).HasMaxLength(10);

                entity.Property(e => e.Text)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('No Item Data Available')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
