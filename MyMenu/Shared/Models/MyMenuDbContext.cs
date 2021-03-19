using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyMenu.Shared.Models
{
    public partial class MyMenuDbContext : DbContext
    {
        public MyMenuDbContext()
        {
        }

        public MyMenuDbContext(DbContextOptions<MyMenuDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<DaysOfWeek> DaysOfWeek { get; set; }
        public virtual DbSet<DiscountPeriods> DiscountPeriods { get; set; }
        public virtual DbSet<DiscountTransaction> DiscountTransaction { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<TimeByDaysOfWeekInMinutes> TimeByDaysOfWeekInMinutes { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCompany> UserCompany { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-K3DI6CJ\\SQLEXPRESS;Database=MyMenuDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(100);
            });

            modelBuilder.Entity<DaysOfWeek>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Days).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<DiscountPeriods>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.ToTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.DiscountPeriods)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_DiscountPeriods_Item");
            });

            modelBuilder.Entity<DiscountTransaction>(entity =>
            {
                entity.HasOne(d => d.Day)
                    .WithMany(p => p.DiscountTransaction)
                    .HasForeignKey(d => d.DayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountTransaction_DaysOfWeek");

                entity.HasOne(d => d.DiscountPeriod)
                    .WithMany(p => p.DiscountTransaction)
                    .HasForeignKey(d => d.DiscountPeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiscountTransaction_DiscountPeriods");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceWithDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(200);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Category");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy).HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Menu)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Menu_Company");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TimeByDaysOfWeekInMinutes>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.TimeSpan)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Salt).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserCompany)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_UserCompany_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserCompany)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserCompany_User");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRole_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
