using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using book.Models;

namespace book.Data
{
    public class bookContext : DbContext
    {
        public bookContext (DbContextOptions<bookContext> options)
            : base(options)
        {
        }

        public DbSet<book.Models.BookViewModel> BookViewModel { get; set; }
    }
}
