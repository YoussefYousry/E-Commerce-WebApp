using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Comm.Models
{
    public class Cart
    {
        //public Cart()
        //{
        //    CartItems = new List<CartItem>();
        //}
        public int Id { get; set; }

        public float TotalPrice { get; set; }

        [ForeignKey(nameof(Users))]
        public string? UsernameFK { get; set; }

        //public ICollection<CartItem> CartItems {get;set;}
    }
}
