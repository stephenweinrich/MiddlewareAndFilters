using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace WebApplication1.Repositories
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<UserDto> GetUsers()
        {
            //var filePath = AppContext.BaseDirectory + @"\data\users.json";
            var filePath = AppContext.BaseDirectory + @"\data\users.json";
            return JsonConvert.DeserializeObject<List<UserDto>>(File.ReadAllText(filePath));            
        }
    }
}
