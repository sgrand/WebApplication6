using WebApplication6.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace WebApplication6.Configuration
{
    public class CategoryConfiguration
    {
        //public CategoryConfiguration(ModelBuilder builder)
        //{
        //    builder.Entity<Category>(e =>
        //    {
        //        e.Property(c => c.CreationUserID).IsRequired();
        //        e.Property(c => c.DateCreated).HasDefaultValueSql("GetDate()");
        //        e.Property(c => c.DateUpdated).HasDefaultValueSql("GetDate()");
        //        e.Property(c => c.Name).IsRequired().HasMaxLength(50);

        //        e.HasOne(p => p.CreationUser).WithMany().OnDelete(DeleteBehavior.Restrict);

        //        e.ToTable("Categories");
        //    });
        //}
    }
}
