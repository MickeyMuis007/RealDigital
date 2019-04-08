using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealDigital.Domain.AggregateModels.ContactAggregate;
using RealDigital.Domain.AggregateModels.ContactAggregate.Builders;
using RealDigital.Domain.AggregateModels.ContactAggregate.Builders.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Persistence.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(50);
            builder.Property(t => t.PhoneNo).IsRequired().HasMaxLength(20);
            builder.Property(t => t.Email).HasMaxLength(255);

            builder.HasData(
                BuilderFactory<ContactBuilder, Contact>.Create()
                    .Set()
                    .SetId(new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E1"))
                    .SetFirstName("Michael")
                    .SetLastName("Hendricks")
                    .SetPhoneNo("0784344321")
                    .SetEmail("michael@mah")
                    .Build(),
                BuilderFactory<ContactBuilder, Contact>.Create()
                    .Set()
                    .SetId(new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E2"))
                    .SetFirstName("Jacob")
                    .SetLastName("Collins")
                    .SetPhoneNo("0784323421")
                    .SetEmail("jacob@mah")
                    .Build(),
                BuilderFactory<ContactBuilder, Contact>.Create()
                    .Set()
                    .SetId(new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E3"))
                    .SetFirstName("Adam")
                    .SetLastName("Antons")
                    .SetPhoneNo("0784346789")
                    .SetEmail("adam@mah")
                    .Build(),
                BuilderFactory<ContactBuilder, Contact>.Create()
                    .Set()
                    .SetId(new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4"))
                    .SetFirstName("James")
                    .SetLastName("Barns")
                    .SetPhoneNo("0732343521")
                    .SetEmail("james@mah")
                    .Build(),
                BuilderFactory<ContactBuilder, Contact>.Create()
                    .Set()
                    .SetId(new Guid("F9168C5E-CEB2-4faa-B6BF-329BF39FA1E5"))
                    .SetFirstName("Tammy")
                    .SetLastName("Micthels")
                    .SetPhoneNo("0784347654")
                    .SetEmail("tammy@mah")
                    .Build()
                );
        }
    }
}
