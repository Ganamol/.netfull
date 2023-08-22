using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreproject.Models;


namespace coreproject.Data
{
    public class coreproject : DbContext
    {
        public coreproject(DbContextOptions<coreproject> options)
                   : base(options)
        {
        }
        public DbSet<coreproject.Models.Movie> Book { get; set; }
    }
}