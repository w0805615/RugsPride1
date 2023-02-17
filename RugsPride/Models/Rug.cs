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

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Brand { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)] 
        public string Color { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)] 
        public string Shape { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)] 
        public string Material { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [System.ComponentModel.DataAnnotations.Schema.Column(TypeName = "decimal(18, 2)")] 
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}
