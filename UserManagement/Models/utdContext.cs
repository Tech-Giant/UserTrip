using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TripManagement.Models
{
    public partial class utdContext : DbContext
    {
        public utdContext()
        {
        }

        public utdContext(DbContextOptions<utdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ExpenseInfo> ExpenseInfo { get; set; }
        public virtual DbSet<TripDetails> TripDetails { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserExpenseInfo> UserExpenseInfo { get; set; }
        public virtual DbSet<UserTripMapping> UserTripMapping { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=CHA-PLP41250;Database=utd;integrated security=true");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseInfo>(entity =>
            {
                entity.Property(e => e.ExpenseInfoId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Currency).HasMaxLength(20);
            });

            modelBuilder.Entity<TripDetails>(entity =>
            {
                entity.HasKey(e => e.TripId);

                entity.Property(e => e.TripId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TripDetails1).HasColumnName("TripDetails");

                entity.Property(e => e.TripName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserExpenseInfo>(entity =>
            {
                entity.Property(e => e.UserExpenseInfoId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserTripMapping>(entity =>
            {
                entity.HasKey(e => e.UserTripId);

                entity.Property(e => e.UserTripId).ValueGeneratedNever();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });
        }
    }
}
