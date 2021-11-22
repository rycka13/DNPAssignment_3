using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using FileData;
using WebClient.Data;
using Models;

namespace WebClient.Authentication
{
    public class InMemoryWebService : IUserService
    {
        private IList<User> users;
        private FileContext _fileContext;

        public InMemoryWebService()
        {
            _fileContext = new FileContext();
            
            
            /*users = new[]
            {
                new User()
                {
                    Username = "Ionut",
                    Id = 2,
                    Password = "12345",
                    SecurityLevel = 4,
                    Role = "Admin",
                },
                new User()
                {
                    Username = "Baicoianu",
                    Id = 3,
                    Password = "12345",
                    SecurityLevel = 2,
                    Role = "Member",
                }
            }.ToList();
            _fileContext.Users.Add(users[0]);*/
            _fileContext.SaveChanges();
            
        }

        public async Task<User> ValidateUserAsync(string username, string password)
        {
            User first = _fileContext.Users.First(user => user.Username.Equals(username));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}