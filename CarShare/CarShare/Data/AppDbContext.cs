using Microsoft.EntityFrameworkCore;
using CarShare.Models; 
namespace CarShare.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<RentalRequest> RentalRequests { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<OwnerAccountApproval> OwnerAccountApprovals { get; set; }
        public DbSet<CarPostApproval> CarPostApprovals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Car
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Owner)
                .WithMany()
                .HasForeignKey(c => c.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Car>()
                .Property(c => c.RentalPrice)
                .HasPrecision(18, 2); // <= ده السطر الجديد


            // RentalRequest
            modelBuilder.Entity<RentalRequest>()
                .HasOne(r => r.Renter)
                .WithMany()
                .HasForeignKey(r => r.RenterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RentalRequest>()
                .HasOne(r => r.Car)
                .WithMany()
                .HasForeignKey(r => r.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            // Feedback
            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Renter)
                .WithMany()
                .HasForeignKey(f => f.RenterId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Car)
                .WithMany()
                .HasForeignKey(f => f.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            // OwnerAccountApproval
            modelBuilder.Entity<OwnerAccountApproval>()
                .HasOne(o => o.Owner)
                .WithMany()
                .HasForeignKey(o => o.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OwnerAccountApproval>()
                .HasOne(o => o.Admin)
                .WithMany()
                .HasForeignKey(o => o.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            // CarPostApproval
            modelBuilder.Entity<CarPostApproval>()
                .HasOne(c => c.Car)
                .WithMany()
                .HasForeignKey(c => c.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CarPostApproval>()
                .HasOne(c => c.Admin)
                .WithMany()
                .HasForeignKey(c => c.AdminId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
