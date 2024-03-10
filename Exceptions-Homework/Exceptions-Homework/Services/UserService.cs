using Exceptions_Homework.Helpers.Exceptions;
using Exceptions_Homework.Models;
using Exceptions_Homework.Services.Interfaces;

namespace Exceptions_Homework.Services
{
    public class UserService : IUserService
    {
        public User[] GetAll()
        {
            User user1 = new()
            {
                Id = 1,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Password = "12345",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),

            };

            User user2 = new()
            {
                Id = 2,
                Name = "Rufat",
                Surname = "Ismayilov",
                Age = 22,
                Email = "rufat@gmail.com",
                Password = "12345",
                Address = "Baki",
                Birthday = new DateTime(2003, 9, 4),

            };

            User user3 = new()
            {
                Id = 3,
                Name = "Cavid",
                Surname = "Bashirov",
                Age = 30,
                Email = "cavid@gmail.com",
                Password = "12345",
                Address = "Siyezen",
                Birthday = DateTime.Now.AddYears(-30),

            };

            User user4 = new()
            {
                Id = 4,
                Name = "Amirastan",
                Surname = "Mereyev",
                Age = 33,
                Email = "Amirastan@gmail.com",
                Password = "12345",
                Address = "Xezer",
                Birthday = DateTime.Now.AddYears(-33),

            };

            User user5 = new()
            {
                Id = 5,
                Name = "Esgerxan",
                Surname = "Bayramov",
                Age = 27,
                Email = "esgerxan@gmail.com",
                Password = "12345",
                Address = "Berde",
                Birthday = DateTime.Now.AddYears(-27),

            };

            User user6 = new()
            {
                Id = 6,
                Name = "Behruz",
                Surname = "Aliyev",
                Age = 21,
                Email = "bahruz@gmail.com",
                Password = "12345",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),

            };

            User user7 = new()
            {
                Id = 7,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Password = "12345",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),

            };
            User user8 = new()
            {
                Id = 8,
                Name = "Ismayil",
                Surname = "Ceferli",
                Age = 24,
                Email = "ismayil@gmail.com",
                Password = "12345",
                Address = "Ehmedli",
                Birthday = DateTime.Now.AddYears(-24),
            };

            return new User[] { user1, user2, user3, user4, user5, user6, user7, user8 };
        }

        public bool Login(User[] users, string email, string password)
        {
            if (password.Length < 6)
            {
                throw new InvalidPasswordException("Password must contain at least 6 characters");
            }

            if (!users.Any(m => m.Email == email && m.Password == password))
            {
                throw new NotFoundException("Email or password is wrong");
            }

            return true;
        }
    }
}
