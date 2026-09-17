using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentConnect.Models;

namespace RentConnect.Data;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Apartment> Apartments => Set<Apartment>();

    public DbSet<ApartmentImage> ApartmentImages =>
        Set<ApartmentImage>();

    public DbSet<ServiceRequest> ServiceRequests =>
        Set<ServiceRequest>();

    public DbSet<UtilityBill> UtilityBills =>
        Set<UtilityBill>();

    public DbSet<Payment> Payments =>
        Set<Payment>();

    public DbSet<UnitAssignment> UnitAssignments =>
        Set<UnitAssignment>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<UnitAssignment>()
            .HasOne(assignment => assignment.Apartment)
            .WithMany()
            .HasForeignKey(assignment => assignment.ApartmentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<UnitAssignment>()
            .HasOne(assignment => assignment.Renter)
            .WithMany()
            .HasForeignKey(assignment => assignment.RenterId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<UnitAssignment>()
            .HasIndex(assignment => assignment.ApartmentId)
            .IsUnique()
            .HasFilter("[IsActive] = 1");

        builder.Entity<UnitAssignment>()
            .HasIndex(assignment => assignment.RenterId)
            .IsUnique()
            .HasFilter("[IsActive] = 1");
    }
}