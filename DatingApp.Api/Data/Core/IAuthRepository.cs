using System.Threading.Tasks;
using DatingApp.Model;

namespace DatingApp.Data
{
    public interface IAuthRepository
    {

        Task<User> Register(User user, string password);

        Task<User> Login(string userName, string password);

        Task<bool> UserExists(string userName);

    }
}