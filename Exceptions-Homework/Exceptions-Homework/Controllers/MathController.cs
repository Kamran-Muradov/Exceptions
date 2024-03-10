using Exceptions_Homework.Services;

namespace Exceptions_Homework.Controllers
{
    public class MathController
    {
        private readonly MathService _mathService;

        public MathController()
        {
            _mathService = new MathService();
        }
        public void Factorial()
        {
            Console.WriteLine("Enter number:");
            string numStr = Console.ReadLine();

            if (int.TryParse(numStr, out int num))
            {
                try
                {
                    Console.WriteLine(_mathService.Factorial(num));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
