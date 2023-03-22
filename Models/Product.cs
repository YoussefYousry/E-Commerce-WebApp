using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_Comm.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is a required field ")]
        [MaxLength(100, ErrorMessage = "Maximum length of the Product Name is 100 characters !")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Manufactureris is a required field ")]
        [MaxLength(100, ErrorMessage = "Maximum length of the Manufacturer is 100 characters !")]
        public string? Manufacturer { get; set; }

        [Required(ErrorMessage = "UnitPrice is a required field ")]
        [MaxLength(10, ErrorMessage = "Maximum length of the UnitPrice is 10 characters !")]
        public float? UnitPrice { get; set; }

        [Required(ErrorMessage = "Discount is a required field ")]
        public float? Discount { get; set; }

        [Required(ErrorMessage = "Quantity a required field ")]
        [MaxLength(3, ErrorMessage = "Maximum length of the Quantity is 3 characters !")]
        public int? Quantity { get; set; }

        [Required(ErrorMessage = "Type a required field ")]
        [MaxLength(15, ErrorMessage = "Maximum length of the Type is 15 characters !")]
        public string? Type { get; set; }

        public string? ImageUrl { get; set; }

        //[ForeignKey(nameof(Users))]
        //public string? UserId { get; set; }

    }
}
