using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Model;

namespace DatingApp.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity);
        void Delete<T>(T entity);

        Task<bool> SaveAll();

        Task<IEnumerable<User>> GetUsers();

        Task<User> GetUser(int id);
    }
}