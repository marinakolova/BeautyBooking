namespace BeautyBooking.Data.Configurations
{
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SalonCategoryConfiguration : IEntityTypeConfiguration<SalonCategory>
    {
        public void Configure(EntityTypeBuilder<SalonCategory> salonCategory)
        {
            salonCategory.HasKey(sc => new { sc.SalonId, sc.CategoryId });
        }
    }
}
