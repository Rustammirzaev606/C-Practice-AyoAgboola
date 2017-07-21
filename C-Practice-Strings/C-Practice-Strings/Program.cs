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

            // 17 WRONG WRONG WRONG!
            //int a1 = rhymeName.IndexOf('a');
            //int a2 = rhymeName.IndexOf('a', (a1 + 1));
            //Console.WriteLine(a2);
            //Console.ReadKey();
            //int a3 = rhymeName.IndexOf("little");
            //int a4 = a3 + "little".Length;
            //int a5 = rhymeName.IndexOf("little", a4);
            //Console.WriteLine($"Index of the 2nd position LITTLE is {a5}.");
            //Console.ReadKey();

            //19 wrong
            //21 wrong
            //Console.WriteLine("The length of Basketball! is {o}", "basketball!".Length);
            //Console.ReadKey();

            string rhyme = "Mary had a little lamb,\nlittle lamb,\nlittle lamb,\nMary had a little lamb that was as white as snow.";
            string lilBig = rhyme.Replace("little", "big big");
            Console.WriteLine(lilBig);
            Console.ReadKey();

            string noLIL = rhyme.Replace("little", "");
            Console.WriteLine(noLIL);
            Console.ReadKey();

            string phoneNumber = "111-222-3333";
            int startPosition = 0;
            int numbOfChars = 3;
            string areaCode = phoneNumber.Substring(startPosition, numbOfChars);   //substring(startPosition, Length) cuts off characters fron the string using start position and the lengh.
            Console.WriteLine(areaCode);
            Console.ReadKey();

            int newStart = 4;
            int newLength = 8;
            string newNumber = phoneNumber.Substring(newStart, newLength);
            Console.WriteLine(newNumber);
            Console.ReadKey();

            int CenOffNumStart = 4;
            int CenOffNumLength = 3;
            string CentOffNum = phoneNumber.Substring(CenOffNumStart, CenOffNumLength);
            Console.WriteLine(CentOffNum);
            Console.ReadKey();

            string howAreYou = "     how  are you?     ";
            string noSpaceX = howAreYou.Replace(" ", "X");
            //string noSpace = howAreYou.Remove(" ");
            Console.WriteLine(noSpaceX);
            Console.ReadKey();

            string trimEnd1 = howAreYou.TrimEnd(); // .trim() removes 'white spaces' from the string. trim() removes it from the whole string, TrimStart() removes white spaces from the beginning of the string and stops as soon as it meets any other character in the string. trimEnd() starts trimming from the end to the start and stops as soon as it meets any other character.
            Console.WriteLine(trimEnd1 + "bruh" );
            Console.ReadKey();
            //32 Formating string output:
            string q1 = "hello";
            string q2 = "jonathan";
            //s1 = s1.PadRight(s1.Length + (s2.Length - s1.Length));
            Console.WriteLine(q1.PadLeft(q1.Length + (q2.Length - q1.Length), '.') );
            Console.WriteLine(q2);
            Console.ReadKey();
            //35
            string x1 = "Mary";
            string x2 = "had";
            string x3 = "a";
            string x4 = "little";
            string x5 = "lamb";
            Console.WriteLine($"{x1,10}");
            Console.WriteLine($"{x2,10}");
            Console.WriteLine($"{x3,10}");
            Console.WriteLine($"{x4,10}");
            Console.WriteLine($"{x5,10}");
            Console.ReadKey();

            

        }
    }
}
