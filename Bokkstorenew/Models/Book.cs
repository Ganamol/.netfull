﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bokkstorenew.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string bookname { get; set; }
        [Required]
        public string Author { get; set; }



    }
}
