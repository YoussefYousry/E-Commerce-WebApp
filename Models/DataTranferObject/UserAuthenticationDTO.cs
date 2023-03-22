using System.ComponentModel.DataAnnotations;

namespace E_Comm.Models.DataTranferObject
{
    public class UserAuthenticationDTO
    {
        [Required(ErrorMessage ="Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Password is required")]

        public string Password { get; set; }
    }
}
