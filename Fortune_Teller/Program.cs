using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FortuneTeller.exe.  This program will tell you your future based on several variables.");
            Console.WriteLine("Please input your first name.  Your input is case-sensitive.");
            string userFirst = Console.ReadLine();
            Console.WriteLine(userFirst);

            Console.WriteLine(userFirst + "?  Interesting.  I will store that information for future reference.");
            Console.WriteLine("Now, please input your last name.");
            string userLast = Console.ReadLine();
            Console.WriteLine(userLast);

            Console.WriteLine("Now, please input your age in numerals.");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine(userAge);

            Console.WriteLine("Please input your birth month in numerals.");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine(birthMonth);

            Console.WriteLine("Please input your favorite ROYGBIV color.  Enter \"Help\" for a list of colors.");
            string favColor = Console.ReadLine().ToLower();
            Console.WriteLine(favColor);

            Console.WriteLine("Finally, please input the number of siblings you have.  Half- and step- siblings also count.");
            int numSiblings = int.Parse(Console.ReadLine());
            Console.WriteLine(numSiblings);

            if (userAge % 2 == 0)
            {
                int yrsToRetire = 30;
            } 
            else if (userAge %2 > 0)
            {
                int yrsToRetire = 45;
            }
            else
            {
                Console.WriteLine("You cannot follow instructions.  Program terminating...");
            }

            
            if (birthMonth >= 1 && birthMonth < 5)
            {
                int moneyInBank = 100;
            }
            else if (birthMonth >= 5 && birthMonth < 9)
            {
                int moneyInBank = 10000;
            }
            else if (birthMonth >= 9 && birthMonth < 12)
            {
                int moneyInBank = 100000000;
            }
            else
            {
                Console.WriteLine("You cannot follow instructions.  Program terminating...");
            }

        }
    }
}
