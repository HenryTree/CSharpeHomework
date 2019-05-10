using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EF.Core
{
    public partial class orderDB2Context : DbContext
    {
        public orderDB2Context()
        {
        }

        public orderDB2Context(DbContextOptions<orderDB2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=.;Port=10024;User Id=root;Password=root123456;Database=orderDB2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PRIMARY");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(150)");

                entity.Property(e => e.ContextKey).HasColumnType("varchar(300)");

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("Order_Id");

                entity.Property(e => e.Id).HasColumnType("varchar(128)");

                entity.Property(e => e.OrderId)
                    .HasColumnName("Order_Id")
                    .HasColumnType("varchar(128)");

                entity.Property(e => e.Product).HasColumnType("longtext");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("Order_Details");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("varchar(128)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Customer).HasColumnType("longtext");
            });
        }
    }
}
