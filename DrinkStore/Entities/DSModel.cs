namespace DrinkStore.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DSModel : DbContext
    {
        public DSModel()
            : base("name=DSModel")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
        public virtual DbSet<ImportDetail> ImportDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.GenderName)
                .IsUnicode(false);

            modelBuilder.Entity<Import>()
                .Property(e => e.TotalCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Import>()
                .HasMany(e => e.ImportDetails)
                .WithRequired(e => e.Import)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ImportDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.TotalCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.UnitCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionCode)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.PositionName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ImportDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Adress)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.PositionCode)
                .IsUnicode(false);

            modelBuilder.Entity<Staff>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Unit>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
