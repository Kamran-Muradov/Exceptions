using Exceptions_Homework.Models;

namespace Exceptions_Homework.Services.Interfaces
{
    public interface IUserService
    {
        User[] GetAll();
        bool Login(User[] users, string username, string password);
    }
}
