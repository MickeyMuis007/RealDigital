using Microsoft.AspNetCore.Hosting;
using RealDigital.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Persistence.Configurations
{
    public class CreateDB
    {
        private readonly RealDigitalContext _context;
        private IHostingEnvironment _hostingEnvironement;

        public CreateDB(RealDigitalContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironement = hostingEnvironment;
        }

        public void Create()
        {
            _context.Database.EnsureCreated();
        }
    }
}
