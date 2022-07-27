
using SreamsCMSLF.Data;
using SreamsCMSLF.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace SreamsCMSLF.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly CmsDbContext userRepository;
        public UserRepository(CmsDbContext cmsDBContext)
        {
             userRepository = cmsDBContext;
        }

        public async  Task<Organization> GetOrganization(int id)
        {
            var Organization =  userRepository.Organizations.Where(x => x.Id == id).FirstOrDefault();
           
            return Organization;
        }

        public async Task<IQueryable<Organization>> GetOrganizations()
        {
            var Organizations =  userRepository.Organizations.ToList();

           return (IQueryable<Organization>)Organizations;
        }

        public async Task<Privilege> GetPrivilege(int id)
        {
            var privilage = userRepository.Privileges.Where(x => x.Id == id).FirstOrDefault();
            return privilage;
        }



        public async Task<User> GetUser(int id)
        {
            var user= userRepository.Users.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }

        public async  Task<IQueryable<User>> GetUsers()
        {
            var users =  userRepository.Users.ToList();
            return (IQueryable<User>)users ;
        }

        public async Task<User> Login(string userName, string password)
        {
            var user =  userRepository.Users.
                Where(x => ((x.User_name.Equals((userName.Trim())) || x.User_name.Equals((userName.Trim()))) && x.Password.Equals(password))).FirstOrDefault();
            return (user != null) ? user : null;
                      
        }
    }
}
