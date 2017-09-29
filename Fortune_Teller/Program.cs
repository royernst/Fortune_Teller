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

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Welcome to Fortune_Teller.exe.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("This program will tell you your future based on several variables.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nPlease input your first name.  Your input is case-sensitive.");
            string userFirst = Console.ReadLine();
            //Console.WriteLine(userFirst);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nNice to meet you, " + userFirst + ".  I will store that information for future reference.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Now, please input your last name.");
            string userLast = Console.ReadLine();
            //Console.WriteLine(userLast);

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nComputing...");
            System.Threading.Thread.Sleep(3000);
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
                Console.WriteLine("You cannot follow directions.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Program terminating...");
            }
            //Console.WriteLine(yrsToRetire + " years to retirement.");

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nInteresting.");
            System.Threading.Thread.Sleep(3000);
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
                Console.WriteLine("You cannot follow directions.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Program terminating...");
            }
            //Console.WriteLine("$" + moneyInBank);

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nMy algorithms are beginning to show a trend line,");
            Console.WriteLine("but I still need more information to make a proper prediction.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nPlease input your favorite ROYGBIV color.  Enter \"Help\" for a list of colors.");
            string favColor = Console.ReadLine().ToLower();
            //Console.WriteLine(favColor);
            while (favColor == "help")
            {
                Console.WriteLine("\nRed\nOrange\nYellow\nGreen\nBlue\nIndigo\nViolet\n\nPlease choose one of the above colors.");
                favColor = Console.ReadLine().ToLower();
                break;
            }
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
                default:
                    xportType = "Short Bus";
                    break;
            }

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nI feel like I will be able to arrive at a prediction soon.");
            System.Threading.Thread.Sleep(2000);
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

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nVery good.  I have all the information I need.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nCalculating . . .");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Calculating . . .");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Calculating . . .");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\n\n{0} {1} will retire in {2} years with ${3} in the bank,", userFirst, userLast, yrsToRetire, moneyInBank);
            Console.WriteLine("a vacation home in {0} and a {1}.", vacHome, xportType);
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nI hope you enjoyed your fortune.  Please run again if you want another fortune.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nProgram Terminating . . .");
        }
    }
}
