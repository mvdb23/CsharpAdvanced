using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CsharpAdvanced23_24.Models;

namespace CsharpAdvanced23_24.Data
{
    public class CsharpAdvanced23_24Context : DbContext
    {
        public CsharpAdvanced23_24Context (DbContextOptions<CsharpAdvanced23_24Context> options)
            : base(options)
        {
        }

        public DbSet<CsharpAdvanced23_24.Models.Landlord> Landlord { get; set; } = default!;

        public DbSet<CsharpAdvanced23_24.Models.Location>? Location { get; set; }
    }
}
