using E_Comm.Models.DataTranferObject;

namespace E_Comm.Constracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserAuthenticationDTO userAuthenticationDTO);
        Task<string> CreateToken(); // 3 functions 
    }
}
