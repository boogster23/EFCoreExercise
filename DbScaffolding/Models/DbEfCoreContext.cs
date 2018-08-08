using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DbScaffolding.Models
{
    public partial class DbEfCoreContext : DbContext
    {
        public DbEfCoreContext()
        {
        }

        public DbEfCoreContext(DbContextOptions<DbEfCoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-D7QI00O;Initial Catalog=DbEfCore;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DeptUniqueId);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.EmpUniqueId);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmpFirstName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.EmpLastName).HasMaxLength(80);

                entity.HasOne(d => d.DeptUnique)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptUniqueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employees_Departments");
            });
        }
    }
}
