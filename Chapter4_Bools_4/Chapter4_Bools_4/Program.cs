using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4_Bools_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine($"Give a value for int x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Give a value for int y:");
            int y = Convert.ToInt32(Console.ReadLine());
            bool result;
            result = x == y;
            Console.WriteLine($"The result of whether {x} is equal {y} is {result}");
            Console.ReadKey();

            bool greaterThan;
            greaterThan = x > y;
            Console.WriteLine($"The result of whether {x} is greater than {y} is {greaterThan}");
            Console.ReadKey();

            bool lessThan = x < y;
            Console.WriteLine($"The result of whether {x} is less than {y} is {lessThan}");
            Console.ReadKey();

            bool greaterOrEqual = x >= y;
            Console.WriteLine($"The result of whether {x} is greater or equal {y} is {greaterOrEqual}");
            Console.ReadKey();

            bool lessOrEqual = x <= y;
            Console.WriteLine($"The result of whether {x} is less or equal {y} is {lessOrEqual}");
            Console.ReadKey();

            bool notEqual = x != y;
            Console.WriteLine($"The result of whether {x} is not equal {y} is {notEqual}");
            Console.ReadKey();

            bool notGreater = !(x > y);
            Console.WriteLine($"The result of whether {x} is not greater than {y} is {notGreater}");
            Console.ReadKey();

            bool fiveSevenGreater = (x > 5 && y > 7);
            Console.WriteLine($"The result of wheter {x} is greater than 5 AND {y} is greater than 7 is {fiveSevenGreater} ");
            Console.ReadKey();
            
        }
    }
}

