using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RugsPride.Models
{
    public class Rug
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Material { get; set; }
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
