using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3.Models
{
    public partial class BankContext : DbContext
    {
        public BankContext()
        {
        }

        public BankContext(DbContextOptions<BankContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Follower> Followers { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LanguageUser> LanguageUsers { get; set; }
        public virtual DbSet<Pikadon> Pikadons { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Follower>(entity =>
            {
                entity.HasOne(d => d.FollowerAferNavigation)
                    .WithMany(p => p.FollowerFollowerAferNavigations)
                    .HasForeignKey(d => d.FollowerAfer)
                    .HasConstraintName("followAfterMe");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("myFollower");
            });

            modelBuilder.Entity<LanguageUser>(entity =>
            {
                entity.HasKey(e => new { e.LanguageId, e.UserId });

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LanguageUsers)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageUsers_Language");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LanguageUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LanguageUsers_User");
            });

            modelBuilder.Entity<Pikadon>(entity =>
            {
                entity.Property(e => e.PikadonId).ValueGeneratedNever();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pikadons)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Pikadon_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
