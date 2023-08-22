using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcore.Models
{
    public class category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string dispalyorder { get; set; }
        public DateTime createddatetime
        { get; set; } = DateTime.Now;
    }
}
