using System;

namespace FizzBuzzApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // div by 3 return "Fizz"
            // div by 5 return "Buzz"
        }
        public static string FizzBuzz(int num)
        {
            var result = num.ToString();
            if (num % 3 == 0 && num % 5 == 0)
            {
                result = "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                result = "Fizz";
            }
            else if (num % 5 == 0)
            {
                result = "Buzz";
            }

            return result;
        }

    }
}