using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViaductMobile.Models;

namespace ViaductMobile.Services.Implementation
{
    public class UserService : IUserService
    {
        private static readonly MobileServiceClient azureService = new MobileServiceClient("https://viaductmobile.azurewebsites.net/");
        
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var table = azureService.GetTable<User>();
            return await table.ReadAsync();
        }
        
        public async Task<IEnumerable<User>> GetUser(string userId)
        {
            var table = azureService.GetTable<User>();
            var query = table.Where(x=>x.Id == userId);
            return await table.ReadAsync(query);
        }
        
        public async Task<User> UpdateUser(User user)
        {
            var table = azureService.GetTable<User>();
            await table.UpdateAsync(user);
            return user;
        }

        public async Task<User> AddUser(User user)
        {
            var table = azureService.GetTable<User>();
            await table.InsertAsync(user);
            return user;
        }
    }
}
