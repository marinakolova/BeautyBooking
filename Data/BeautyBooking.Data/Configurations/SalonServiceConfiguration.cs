namespace BeautyBooking.Data.Configurations
{
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SalonServiceConfiguration : IEntityTypeConfiguration<SalonService>
    {
        public void Configure(EntityTypeBuilder<SalonService> salonService)
        {
            salonService.HasKey(ss => new { ss.SalonId, ss.ServiceId });
        }
    }
}
