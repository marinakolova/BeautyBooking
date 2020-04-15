namespace BeautyBooking.Data.Configurations
{
    using BeautyBooking.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BlogPostCategoryConfiguration : IEntityTypeConfiguration<BlogPostCategory>
    {
        public void Configure(EntityTypeBuilder<BlogPostCategory> blogPostCategory)
        {
            blogPostCategory.HasKey(bpc => new { bpc.BlogPostId, bpc.CategoryId });
        }
    }
}
