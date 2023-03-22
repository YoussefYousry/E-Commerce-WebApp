namespace E_Comm.Models.DataTranferObject
{
    public class ProductCreationDTO
    {
        public string? Name { get; set; }

        public string? Manufacturer { get; set; }

        public float UnitPrice { get; set; }

        public float Discount { get; set; }

        public int Quantity { get; set; }

        public string? Type { get; set; }

        public string? ImageUrl { get; set; }

    }
}
