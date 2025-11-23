using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GameEnergy.Models
{
    public partial class GameEnergyModel : DbContext
    {
        public GameEnergyModel()
            : base("name=GameEnergyModel3")
        {
        }

        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartItems> CartItems { get; set; }
        public virtual DbSet<GameDevelopers> GameDevelopers { get; set; }
        public virtual DbSet<GameGenres> GameGenres { get; set; }
        public virtual DbSet<GameReportCategory> GameReportCategory { get; set; }
        public virtual DbSet<GameReports> GameReports { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<Genres> Genres { get; set; }
        public virtual DbSet<MainCategory> MainCategory { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<SystemNotifications> SystemNotifications { get; set; }
        public virtual DbSet<UserLibrary> UserLibrary { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
                .Property(e => e.TotalAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CartItems>()
                .Property(e => e.PriceAtAdd)
                .HasPrecision(10, 2);

            modelBuilder.Entity<GameReportCategory>()
                .HasMany(e => e.GameReports)
                .WithRequired(e => e.GameReportCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Games>()
                .Property(e => e.AverageRating)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Games>()
                .HasMany(e => e.CartItems)
                .WithRequired(e => e.Games)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Games>()
                .HasMany(e => e.GameReports)
                .WithRequired(e => e.Games)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Games>()
                .HasMany(e => e.OrderItems)
                .WithRequired(e => e.Games)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Games>()
                .HasMany(e => e.Reviews)
                .WithOptional(e => e.Games)
                .WillCascadeOnDelete();

            modelBuilder.Entity<OrderItems>()
                .Property(e => e.PriceAtPurchase)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Orders>()
                .Property(e => e.TotalAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<UserRoles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.UserRoles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Cart)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.GameReports)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Reviews)
                .WithOptional(e => e.Users)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Users>()
                .HasMany(e => e.SystemNotifications)
                .WithRequired(e => e.Users)
                .WillCascadeOnDelete(false);
        }
    }
}
