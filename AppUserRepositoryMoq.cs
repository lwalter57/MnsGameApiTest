using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI_MNS_Games.Abstractions;
using WebAPI_MNS_Games.Domain.Services;
using WebAPI_MNS_Games.Models;
using WebAPI_MNS_Games.Repo;

namespace MNSApiTest
{
    public class AppUserRepositoryMoq : IAppUserRepository
    {
        public List<AppUser> AppUsers { get; set; }
        public AppUserRepositoryMoq() 
        {
            AppUsers = new List<AppUser>();
        }
        public IEnumerable<AppUser> GetAllUsers()
        {
            return AppUsers;
        }
        public string CreateAppUser(AppUser appUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppUser(int id)
        {
            throw new NotImplementedException();
        }


        public AppUser GetAppUserModelById(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateAppUser(AppUser appUser, int id)
        {
            throw new NotImplementedException();
        }
    }
}
