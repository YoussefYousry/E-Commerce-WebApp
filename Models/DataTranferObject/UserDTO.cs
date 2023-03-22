namespace E_Comm.Models.DataTranferObject
{
    public class UserDTO
    {
        public string? Id { get; set; }
        public string? FullName { get; set; }

        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public string? UserName { get; set; }

        public DateTime CreatedOn { get; set; }


    }
}
