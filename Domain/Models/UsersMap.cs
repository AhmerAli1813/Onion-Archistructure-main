using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UsersMap
    { 

            public UsersMap(EntityTypeBuilder<Users> entityTypeBuilder)
            {
            entityTypeBuilder.HasKey(t => t.Id);
            entityTypeBuilder.Property(t => t.Email).IsRequired();
            entityTypeBuilder.Property(t => t.password).IsRequired();
            entityTypeBuilder.Property(t => t.Username).IsRequired();
            entityTypeBuilder.HasOne(t => t.usersProfile).WithOne(u => u.users).HasForeignKey<UsersProfile>(x => x.Id);
        }
    }
}
