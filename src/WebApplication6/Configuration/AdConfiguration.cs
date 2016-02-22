using WebApplication6.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace WebApplication6.Configuration
{
    public class AdConfiguration
    {
        //public AdConfiguration(ModelBuilder builder)
        //{
        //    builder.Entity<Ad>(e =>
        //    {
        //        e.HasOne(pt => pt.OwnerUser)
        //        .WithMany(r => r.OwnedAds)
        //        .HasForeignKey(r => r.OwnerUserID);
        //         e.HasOne(pt => pt.CreationUser)
        //        .WithMany(r => r.CreatedAds)
        //        .HasForeignKey(f => f.CreationUserID);
        //        e.HasOne(p => p.OwnerUser).WithMany().OnDelete(DeleteBehavior.Restrict);
        //        e.HasOne(p => p.CreationUser).WithMany().OnDelete(DeleteBehavior.Restrict);
        //        e.Property(c => c.OwnerUserID).IsRequired();
        //        e.Property(c => c.OwnerUserID).IsRequired();
        //        e.Property(c => c.CreationUserID).IsRequired();
        //        e.Property(c => c.DateCreated).HasDefaultValueSql("GetDate()");
        //        e.Property(c => c.DateUpdated).HasDefaultValueSql("GetDate()");
        //        e.Property(c => c.Name).IsRequired().HasMaxLength(50);
        //        e.ToTable("Ads");
        //    });
        //}
    }
}
