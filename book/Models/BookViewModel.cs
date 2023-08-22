using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace book.Models
{
    public class BookViewModel
    {
        [Key]
        public int BookID { get; set; }
       [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
       [Range(1,int.MaxValue,ErrorMessage ="Shoud be greater than 1")]
        public string Price { get; set; }

    }
}
