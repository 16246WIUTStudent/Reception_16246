using Microsoft.EntityFrameworkCore;

namespace API_16246.Models
{
    public class ReceptionDbContext : DbContext
    {
        public ReceptionDbContext(DbContextOptions<ReceptionDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Foreign Key Relationships
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Guest)
                .WithMany(g => g.Reservations)
                .HasForeignKey(r => r.GuestId);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(ro => ro.Reservations)
                .HasForeignKey(r => r.RoomId);

            modelBuilder.Entity<Room>()
        .Property(r => r.PricePerNight)
        .HasColumnType("decimal(10, 2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
