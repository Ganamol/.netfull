using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Movie>().HasData(
               new Movie
               {
                   Id = 100,
                   Title = "hhh",
                   ReleaseDate = DateTime.Now,
                   Genre = "jjh",
                   Price = 29
               }
              ,
            new Movie
            {
                Id = 101,
                Title = "theeram",
                ReleaseDate = DateTime.Now,
                Genre = "jayan",
                Price = 29
            },
              new Movie
              {
                  Id = 102,
                  Title = "Manichithrathazhu",
                  ReleaseDate = DateTime.Now,
                  Genre = "KBV",
                  Price = 29
              }

               );
        }
    }


}    

