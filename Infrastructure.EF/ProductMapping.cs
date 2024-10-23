using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.EF
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // تنظیمات مربوط به جدول
            builder.ToTable("Products");

         

            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(100); // نام محصول الزامی و حداکثر طول 100 کاراکتر دارد

            builder.Property(p => p.Description)
                   .IsRequired(); 

            // سایر تنظیمات
        }
    }
}
