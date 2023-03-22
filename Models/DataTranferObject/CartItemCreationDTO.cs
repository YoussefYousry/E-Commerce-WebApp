namespace E_Comm.Models.DataTranferObject
{
    public class CartItemCreationDTO
    {
        public string? Name { get; set; }

        public float UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string? ImageUrl { get; set; }
        public int CartId { get; set; }

    }
}
