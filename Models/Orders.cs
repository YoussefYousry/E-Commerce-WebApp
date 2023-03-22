using System.ComponentModel.DataAnnotations.Schema;

namespace E_Comm.Models
{
    public class Orders
    {

        [Column("OrderNo")]
        public int Id { get; set; }

        [Column("TotalPrice")]
        public float OrderTotal { get; set; }

        public string? OrderStatus { get; set; }

        [ForeignKey(nameof(Users))]
        public string UsernameFK { get; set; }

        //public ICollection<OrderItems>? OrderItems { get; set; }



    }
}
