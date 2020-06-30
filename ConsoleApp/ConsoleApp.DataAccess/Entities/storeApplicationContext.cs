using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp.DataAccess.Entities
{
    public partial class storeApplicationContext : DbContext
    {
        public storeApplicationContext()
        {
        }

        public storeApplicationContext(DbContextOptions<storeApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<InventoryStocked> InventoryStocked { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Store> Store { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:trainingalfred.database.windows.net,1433;Initial Catalog=storeApplication;Persist Security Info=False;User ID=rwagajua;Password=Rwagie@sue18;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK__Customer__9725F2E6D04323F5");

                entity.Property(e => e.CustId).HasColumnName("custID");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InventoryStocked>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inventory_Stocked");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Stock).HasDefaultValueSql("((0))");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.HasOne(d => d.Prod)
                    .WithMany()
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__ProdI__6D0D32F4");

                entity.HasOne(d => d.Store)
                    .WithMany()
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Inventory__Store__6C190EBB");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order_Details");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Det__Order__656C112C");

                entity.HasOne(d => d.Prod)
                    .WithMany()
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Order_Det__ProdI__66603565");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__C3905BAFBD2E6C20");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Orders__CustID__628FA481");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__Product__042785C50BADE1E1");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Store__ProdID__693CA210");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
