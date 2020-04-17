namespace BeautyBooking.Data.Configurations
{
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SalonConfiguration : IEntityTypeConfiguration<Salon>
    {
        public void Configure(EntityTypeBuilder<Salon> salon)
        {
            salon
                .HasOne(s => s.Category)
                .WithMany(c => c.Salons)
                .HasForeignKey(s => s.CategoryId);

            salon
                .HasMany(s => s.Services)
                .WithOne(s => s.Salon)
                .HasForeignKey(s => s.SalonId);
        }
    }
}
