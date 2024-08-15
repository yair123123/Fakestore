using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Fakestore.Models;

namespace Fakestore.Data
{
    public class FakestoreContext : DbContext
    {
        public FakestoreContext (DbContextOptions<FakestoreContext> options)
            : base(options)
        {
        }

        public DbSet<Fakestore.Models.Item> Item { get; set; } = default!;
    }
}
