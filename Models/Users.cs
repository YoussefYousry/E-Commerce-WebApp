
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Comm.Models
{
    public class Users : IdentityUser
    {
        public Users()
        {
            CreatedOn = DateTime.Now;

        }
        //[Column("UserId")]
        //public int ID { get; set; }
        [Required(ErrorMessage = "FirstName is a required field ")]
        [MaxLength(40,ErrorMessage ="Maximum length of the FirstName is 40 characters !")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName is a required field ")]
        [MaxLength(40, ErrorMessage = "Maximum length of the LastName is 40 characters !")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "E-mail is a required field ")]
        //[MaxLength(50, ErrorMessage = "Maximum length of the E-mail is 50 characters !")]
        //public string Email { get; set; }

        [Required(ErrorMessage = "Gender is a required field ")]
        [MaxLength(20, ErrorMessage = "Maximum length of the Gender is 20 characters !")]
        public string Gender { get; set; }

        public float Fund { get; set; }

        //[Required(ErrorMessage = "Mobile Number is a required field ")]
        //[MaxLength(11, ErrorMessage = "Maximum length of the Mobile Number is 11 characters !")]
        //public int MobileNo { get; set; } 
        
        //public string Type { get; set; }

        public DateTime CreatedOn { get; set; }

        //[Required(ErrorMessage = "Password is a required field ")]
        //[MaxLength(40, ErrorMessage = "Maximum length of the Password is 40 characters !")]
        //public string Password { get; set; }

    }
}
