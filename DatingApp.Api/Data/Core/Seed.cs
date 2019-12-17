using Microsoft.EntityFrameworkCore;
using DatingApp.Model;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Data
{
    public class Seed
    {
        public static void SeedUsers(DataContext context)
        {
            if (!context.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                foreach (var user in users)
                {
                    byte[] passwordHash, passwordSalt;
                    CreatePasswordHash("password", out passwordHash, out passwordSalt);

                    user.UserName = user.UserName.ToLower();
                    user.PasswordHash = passwordHash;
                    user.PasswordSalt = passwordSalt;
                    context.Users.Add(user);
                }

                context.SaveChanges();
            }
        }

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }
}