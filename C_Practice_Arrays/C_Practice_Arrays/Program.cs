using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bruh = new int[50];
            Console.WriteLine(bruh.Length);
            
            Console.WriteLine(bruh.Rank);
            Console.ReadLine();
            double[] burh1 = new double[] { 1.4e9, 1.39e9, 42, 43.8, 8, 23.64, 18, 200 };
            Console.WriteLine($"The array is : {burh1[0]} {burh1[1]} {burh1[2]} {burh1[3]} {burh1[4]} {burh1[5]} {burh1[6]} {burh1[7]}");
            Console.ReadKey();
            Array.Sort(burh1);
            Console.WriteLine($"Now the array is {burh1[0]} {burh1[1]} {burh1[2]} {burh1[3]} {burh1[4]} {burh1[5]} {burh1[6]} {burh1[7]}");
            Console.ReadKey();
            int[] array99 = new int[] { 17, 42, 43, 8, 23 };
            Console.WriteLine($"{array99[0]} {array99[1]} {array99[2]} {array99[3]} {array99[4]}");
            Array.Resize<int>(ref array99, 7);
            array99[5] = 57;
            array99[6] = 84;
            Console.WriteLine($"{array99[0]} {array99[1]} {array99[2]} {array99[3]} {array99[4]}  {array99[5]}  {array99[6]}");
            Console.ReadKey();
            DateTime date = DateTime.Now;
            DateTime s1 = DateTime.UtcNow;
            Console.WriteLine($"{date}--- {s1}");
            Console.ReadKey();
        }
    }
}
