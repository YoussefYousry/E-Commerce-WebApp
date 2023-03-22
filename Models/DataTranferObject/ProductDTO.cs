using System.ComponentModel.DataAnnotations.Schema;

namespace E_Comm.Models.DataTranferObject
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string? Manufacturer { get; set; }
        public float UnitPrice { get; set; }

        public float? Discount { get; set; }
        public int? Quantity { get; set; }
        public string? ImageUrl { get; set; }
        public string? Type { get; set; }


    }
}
