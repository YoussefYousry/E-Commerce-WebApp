namespace E_Comm.Models.DataTranferObject
{
    public class CartDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public float UnitPrice { get; set; }

        public int Quantity { get; set; }

        public string? ImageUrl { get; set; }
    }
}
