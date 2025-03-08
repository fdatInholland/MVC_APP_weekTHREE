using MvcWhatsUp.Models;

namespace MvcWhatsUp.Repositories
{
    public interface IUsersRepository
    {
        List<User> GetAllUsers();
        User? GetUserByID(int userId);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
    }
}
