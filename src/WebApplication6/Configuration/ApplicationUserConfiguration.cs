using WebApplication6.Models;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;

namespace WebApplication6.Configuration
{
    public class ApplicationUserConfiguration
    {
        public ApplicationUserConfiguration(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>(typeBuilder =>
                         {
                             typeBuilder.Property<string>(u => u.Language)
                                 .HasDefaultValue("en")
                                 .IsRequired();
                         });
        }
    }
}
