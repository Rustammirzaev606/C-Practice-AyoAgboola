using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number to work with");
            string firstNum = Console.ReadLine();
            int num1;
            double firstDouble;
            int.TryParse(firstNum, out num1);
            Console.WriteLine("Give me a double to work with");
            string secondDouble = Console.ReadLine();
            double.TryParse(secondDouble, out firstDouble);
            //MultiplyIntegers();
            //MultiplyIntegers(num1);
            //MultiplyIntegers(firstDouble);
            Console.WriteLine("Gimme another int");
            string bruh = Console.ReadLine();
            int newNum;
            int.TryParse(bruh, out newNum);

            MultiplyIntegers(newNum, num1);
            MultiplyIntegers(num1);
        




        }
        public static void MultiplyIntegers()
        {
            int num2 = 2;
            Console.WriteLine($"the {num2} is here witn no integers!");
            Console.ReadKey();

        }
        public static void MultiplyIntegers(int num1)
        {
            Console.WriteLine($"the {num1}  is here with one integer!");
            Console.ReadKey();

        }
        public static void MultiplyIntegers(int number1, int num2)
        {

            int product = number1 * num2;
            Console.WriteLine($"The product of {number1} and {num2} is {product}");
            Console.ReadKey();

        }
        public static void MultiplyIntegers(double valDouble)
        {
            Console.WriteLine($"The first double value is here {valDouble}!!!");
            Console.ReadLine();
        }

    }
}
