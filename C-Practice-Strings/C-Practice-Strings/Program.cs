using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "John";
            string lastName = "Leavings";
            string fullName = "John " + "Leavings";
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.Length);
            Console.ReadKey();
            Console.WriteLine($"What if your first name?:");
            string fName = Console.ReadLine().ToUpper();
            Console.WriteLine($"What is your last name?:");
            string lName = Console.ReadLine().ToUpper();
            Console.WriteLine($"Your full name is {lName}, {fName}");
            Console.ReadKey();
            string s1 = "Hello.";
            string s2 = "Hello.";
            bool x = (s1 == s2);
            bool y = (s1.Equals(s2));
            bool z = String.Equals(s1, s2);
            Console.ReadKey();

            string rhymeName = "Mary had a little lamb";
            int letterPosition = rhymeName.IndexOf("i");
            Console.WriteLine($"The position of 'i' is: {letterPosition}");
            Console.WriteLine($"The position of 'd' is {rhymeName.IndexOf("d")}");
            Console.ReadKey();

            // 17
            int a1 = rhymeName.IndexOf('a');
            int a2 = rhymeName.IndexOf('a', (a1 + 1));
            Console.WriteLine(a2);
            Console.ReadKey();


        }
    }
}
