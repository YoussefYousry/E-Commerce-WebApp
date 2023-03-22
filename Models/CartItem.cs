using System.ComponentModel.DataAnnotations.Schema;

namespace E_Comm.Models
{
    public class CartItem
    {
        public CartItem()
        {
            cart = new Cart();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }

        [ForeignKey(nameof(Cart))]
        public int CartIdFK { get; set; }

        public Cart cart { get; set; }

    }
}
