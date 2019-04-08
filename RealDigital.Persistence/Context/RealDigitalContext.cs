using Microsoft.EntityFrameworkCore;
using RealDigital.Domain.AggregateModels.ContactAggregate;
using RealDigital.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Persistence.Context
{
    public class RealDigitalContext : DbContext
    {
        public RealDigitalContext(DbContextOptions<RealDigitalContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContactConfiguration());
        }
    }
}
