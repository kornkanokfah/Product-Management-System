using System.ComponentModel.DataAnnotations;

namespace ProductMS.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please Enter Product Description")]
        public string ProductDescription { get; set; }

        [Range(1, 1000, ErrorMessage = "please Enter a number greater than 0 ")]
        public int Price { get; set; }

        [Range(1, 1000, ErrorMessage = "please Enter a number greater than 0")]
        public int StockQuantity { get; set; }
    }
}
