using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorApp.Model;

namespace RazorApp.Data
{
    public class RazorAppContext : DbContext
    {
        public RazorAppContext (DbContextOptions<RazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<RazorApp.Model.User> User { get; set; } = default!;
    }
}
