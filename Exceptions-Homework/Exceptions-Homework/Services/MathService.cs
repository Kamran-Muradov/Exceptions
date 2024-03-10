using Exceptions_Homework.Helpers.Exceptions;

namespace Exceptions_Homework.Services
{
    public class MathService
    {
        public int Factorial(int num)
        {
            if (num < 0)
            {
                throw new MathException("Attemped to calculate negative number factorial");
            }

            int fact = 1;

            for (int i = 2; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
