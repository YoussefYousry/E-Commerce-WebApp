namespace E_Comm.Models.DataTranferObject
{
    public class OrderForCreationDTO
    {
        public float OrderTotal { get; set; }

        public string? OrderStatus { get; set; }

        public string UsernameFK { get; set; }
    }
}
