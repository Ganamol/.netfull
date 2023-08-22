using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bokkstorenew.Models;

namespace Bokkstorenew.Data
{
    public class BokkstorenewContext : DbContext
    {
        public BokkstorenewContext (DbContextOptions<BokkstorenewContext> options)
            : base(options)
        {
        }

        public DbSet<Bokkstorenew.Models.Book> Book { get; set; }
    }
}
