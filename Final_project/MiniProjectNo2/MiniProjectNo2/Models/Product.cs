using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProjectNo2.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name Is Required")]
        public string ProductName { get; set; }
        public float Price { get; set;}
        public string Brand { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpirtionDate { get; set; }


    }
}
