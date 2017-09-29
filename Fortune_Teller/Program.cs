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
            string yrsToRetire = " ";
            string moneyInBank = " ";
            string xportType = " ";
            string vacHome = " ";

            Console.WriteLine("Welcome to FortuneTeller.exe.  This program will tell you your future based on several variables.");
            Console.WriteLine("Please input your first name.  Your input is case-sensitive.");
            string userFirst = Console.ReadLine();
            //Console.WriteLine(userFirst);

            Console.WriteLine("\n" + userFirst + "?  Interesting.  I will store that information for future reference.");
            Console.WriteLine("Now, please input your last name.");
            string userLast = Console.ReadLine();
            //Console.WriteLine(userLast);

            Console.WriteLine("\nNow, please input your age in numerals.");
            int userAge = int.Parse(Console.ReadLine());
            //Console.WriteLine(userAge);

            if (userAge < 0)
            {
                yrsToRetire = "1,000,000";
            }
            else if (userAge % 2 > 0)
            {
                yrsToRetire = "45";
            }
            else if (userAge % 2 == 0)
            {
                yrsToRetire = "30";
            }
            else
            {
                Console.WriteLine("You cannot follow directions.  Program terminating...");
            }
            //Console.WriteLine(yrsToRetire + " years to retirement.");


            Console.WriteLine("\nPlease input your birth month in numerals.");
            int birthMonth = int.Parse(Console.ReadLine());
            //Console.WriteLine(birthMonth);

            if (birthMonth >= 1 && birthMonth < 5)
            {
                moneyInBank = "100";
            }
            else if (birthMonth >= 5 && birthMonth < 9)
            {
                moneyInBank = "10,000";
            }
            else if (birthMonth >= 9 && birthMonth < 12)
            {
                moneyInBank = "100,000,000";
            }
            else if (birthMonth <= 0 || birthMonth > 12)
            {
                moneyInBank = "0";
            }
            else
            {
                Console.WriteLine("You cannot follow directions.  Program terminating...");
            }
            //Console.WriteLine("$" + moneyInBank);


            Console.WriteLine("\nPlease input your favorite ROYGBIV color.  Enter \"Help\" for a list of colors.");
            string favColor = Console.ReadLine().ToLower();
            //Console.WriteLine(favColor);

            switch (favColor)
            {
                case "red":
                    xportType = "Limousine";
                    break;
                case "orange":
                    xportType = "Combine Harvester";
                    break;
                case "yellow":
                    xportType = "Tugboat";
                    break;
                case "green":
                    xportType = "Tesla Model S";
                    break;
                case "blue":
                    xportType = "F-16 Fighter Jet";
                    break;
                case "indigo":
                    xportType = "Yellow Submarine";
                    break;
                case "violet":
                    xportType = "Popemobile";
                    break;
                case "help":
                    Console.WriteLine("Red\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\nPlease restart Fortune_Teller.exe");
                    break;
                default:
                    xportType = "Short Bus";
                    break;
            }


            Console.WriteLine("\nFinally, please input the number of siblings you have.  Half- and step- siblings also count.");
            int numSiblings = int.Parse(Console.ReadLine());
            //Console.WriteLine(numSiblings);

            if (numSiblings == 0)
            {
                vacHome = "Dublin, Ireland";
            }
            else if (numSiblings == 1)
            {
                vacHome = "Oslo, Norway";
            }
            else if (numSiblings == 2)
            {
                vacHome = "Madrid, Spain";
            }
            else if (numSiblings == 3)
            {
                vacHome = "Paris, France";
            }
            else if (numSiblings > 3)
            {
                vacHome = "Littleton, West Virginia, USA";
            }
            else
            {
                vacHome = "Pripyat, Ukraine";
            }


            Console.WriteLine("{0} {1} will retire in {2} years with ${3} in the bank,", userFirst, userLast, yrsToRetire, moneyInBank);
            Console.WriteLine("a vacation home in {0} and a {1}.", vacHome, xportType);
        }
    }
}
