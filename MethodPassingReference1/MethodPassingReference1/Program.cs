using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReference1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine($"In the main method x = {x}");
            DisplayValueParameter(x);
            DisplayNewValue(ref x);
            
            Console.WriteLine(x);
            Console.ReadLine();
        }

        private static void DisplayValueParameter(int x)
        {
            x = 1000;
            Console.WriteLine($"We are in the DisplayValueParameter Method where x = {x}");
        }

        private static void DisplayNewValue(ref int n)
        {
            n = 1000;
            Console.WriteLine($"We are in the DUDEDUDEDUDE Method where x = {n}");
        }


    }
}
