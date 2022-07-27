using SreamsCMSLF.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SreamsCMSLF.Repositories
{
    public interface IUserRepository
    {
        Task<IQueryable<User>> GetUsers();
        Task<IQueryable<Organization>> GetOrganizations ();
        Task<User> GetUser(int id);
        Task<Privilege> GetPrivilege(int id);
        Task<Organization> GetOrganization(int id);
        Task<User> Login(string userName,string password);


    }
}
