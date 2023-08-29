using FiapStoreMinimalAPI.Entities;
using FiapStoreMinimalAPI.Interface;

namespace FiapStoreMinimalAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private IList<User> _users = new List<User>();

        public IList<User> GetAllUsers()  
        {
            return _users;
        }
        public User GetUserById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public void DeleteUser(int id)
        {
            _users.Remove(GetUserById(id));
        }
        public void UpdateUser(User user) 
        {
            User userUpdated = GetUserById(user.Id);
            if (userUpdated != null)
                userUpdated.Name = user.Name;

        }
    }
}
