using E_Comm.Constracts;
using E_Comm.Models;

namespace E_Comm.Reposiotry
{
    public class UsersRepository : RepositoryBase<Users> , IUsresRepository

    {

        public UsersRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
            
            
        }
        public void createUser(Users user)
        {
            Create(user);
        }

        public void deleteUser(Users user)
        {
            Delete(user);
        }

        public IEnumerable<Users> getAllUsers(bool trackChanges)

            => FindAll(trackChanges).OrderBy(U => U.Id).ToList();

        public Users? getUserById(int userId, bool trackChanges)

            => FindByCondition(U => U.Id.Equals(userId), trackChanges).FirstOrDefault();



        public void updateUser(Users user)
        {
            Update(user);
        }
    }

}
