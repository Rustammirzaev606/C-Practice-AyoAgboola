using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassingReferenceStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sponge Bob";
            string lastName = "Square Pants";
            Console.WriteLine($"Who lives in a pineapple under the sea?\n {firstName} {lastName}");
            Console.ReadKey();
            PatricksName(ref firstName, ref lastName);
            Console.ReadKey();
            Console.WriteLine($"{firstName} {lastName} lives under the rock!");
            Console.ReadKey();
            BobsName(ref firstName, ref lastName);
            Console.ReadKey();
            Console.WriteLine($"If nautical nonsense be something you wish\n {firstName} {lastName}");
            Console.ReadKey();

            Console.WriteLine("player 1... what is your name??");
            string player1 = Console.ReadLine();
            Console.WriteLine("player 2... what is your name??");
            string player2 = Console.ReadLine();
            Console.WriteLine(player1 + ' ' + player2);
            NameChange(ref player1, ref player2);
            Console.ReadLine();
        }
        public static void NameChange(ref string q1, ref string q2)
        {
            q1 = "Player Unknown's";
            q2 = "Battle Grounds";
            Console.WriteLine($"{q1}  {q2}");
        }
        private static void PatricksName(ref string x,ref string y)
        {
            x = "Patrick";
            y = "Star";
            Console.WriteLine($"Hi's dumb friend is {x} {y}");

        }

        private static void BobsName(ref string x, ref string y)
        {
            x = "Spongebob";
            y = "Squarepants";
            Console.WriteLine($"Absorbant and yellow and porous is he!?\n {x} {y}");
        }
    }
}
