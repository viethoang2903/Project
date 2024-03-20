using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Models
{
    public partial class MyProjectContext : DbContext
    {
        public MyProjectContext()
        {
        }

        public MyProjectContext(DbContextOptions<MyProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Account> Account { get; set; } = null!;
        public IEnumerable<object> YourEntities { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-J9TM44T;database=MyProject;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.ToTable("Account");

                entity.Property(e => e.Username).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);
            });
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey((e => e.Id));

                entity.ToTable("Student");

                entity.Property(e => e.Address).HasMaxLength(30);

                entity.Property(e => e.Gpa)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("GPA");

                entity.Property(e => e.Id)
                    .HasMaxLength(30)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(30);
                
            });
            
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
