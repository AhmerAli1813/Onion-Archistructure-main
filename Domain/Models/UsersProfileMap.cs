using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UsersProfileMap
    {
        public UsersProfileMap(EntityTypeBuilder<UsersProfile> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.FirtName).IsRequired();
            entityTypeBuilder.Property(t => t.LastName).IsRequired();
            entityTypeBuilder.Property(t => t.contactNo).IsRequired();
            entityTypeBuilder.Property(t => t.Address).IsRequired();
            entityTypeBuilder.Property(t => t.Address).HasMaxLength(100);
        }
    }
}
