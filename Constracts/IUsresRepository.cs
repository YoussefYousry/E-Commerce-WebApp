using E_Comm.Models;

namespace E_Comm.Constracts
{
    public interface IUsresRepository
    {
        void createUser(Users user);//user action
        void updateUser(Users user);    // user action
        void deleteUser(Users user); //admin action
        Users getUserById(int userId, bool trackChanges);
        IEnumerable<Users> getAllUsers(bool trackChanges);





    }
}
