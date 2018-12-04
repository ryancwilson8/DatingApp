using System.Threading.Tasks;
using newApp.API.Models;

namespace newApp.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);

        Task<bool> UserExists(string username);
    }
}