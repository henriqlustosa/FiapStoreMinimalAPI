using FiapStoreMinimalAPI.Entities;

namespace FiapStoreMinimalAPI.Interface
{
    public interface IUserRepository
    {
        IList<User> GetAllUsers();
        User GetUserById(int id);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
