﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
      
        public string Title { get; set; }

      
        public DateTime ReleaseDate { get; set; }

        
        public string Genre { get; set; }

     
        public int Price { get; set; }
      
    }
}
