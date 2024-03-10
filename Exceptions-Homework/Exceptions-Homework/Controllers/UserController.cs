using Exceptions_Homework.Services;

namespace Exceptions_Homework.Controllers
{
    public class UserController
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }
        public void Login()
        {
        Login: Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            var users = _userService.GetAll();

            try
            {
                if (_userService.Login(users, email, password))
                {
                    Console.WriteLine("Login success");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ". Please try again:");
                goto Login;
            }
        }
    }
}
