using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        public static void killSwitch()
        {
            Environment.Exit(0);
        }
        static void Main(string[] args)
        {
            string yrsToRetire = " ";
            string moneyInBank = " ";
            string xportType = " ";
            string vacHome = " ";
            int userAge = 0;
            int birthMonth = 0;
            int numSiblings = 0;

            Console.WriteLine("Welcome to Fortune_Teller.exe.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nThis application will predict your future based on several variables.");
            Console.WriteLine("You can type \"Quit\" at any time to exit the application.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nPlease input your first name.  Your input is case-sensitive.");
            string userFirst = Console.ReadLine();
            if (userFirst.ToLower() == "quit")
            {
                killSwitch();
            }
            else
            {
                //intentionally left blank
            }


            Console.WriteLine("\nNice to meet you, " + userFirst + ".\nI will store that information for future reference.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nNow, please input your last name.");
            string userLast = Console.ReadLine();
            if (userLast.ToLower() == "quit")
            {
                killSwitch();
            }
            else
            {
                //intentionally left blank
            }
            //Takes user first and last names

            Console.WriteLine("\nComputing...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nNow, please input your age in numerals.");
            string ageInput = Console.ReadLine().ToLower();
            if (ageInput == "quit")
            {
                killSwitch();
            }
            else
            {
                userAge = int.Parse(ageInput);
            }
            //Takes userAge, sends through ;

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

            Console.WriteLine("\nInteresting.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nPlease input your birth month in numerals.");
            string birthInput = Console.ReadLine().ToLower();
            if (birthInput == "quit")
            {
                killSwitch();
            }
            else
            {
                birthMonth = int.Parse(birthInput);
            }
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
            //another identifier based on birth month

            Console.WriteLine("\nMy algorithms are beginning to show a trend line,");
            Console.WriteLine("but I still need more information to make a proper prediction.");
            System.Threading.Thread.Sleep(2000);
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
                case "quit":
                    killSwitch();
                    break;
                default:
                    xportType = "Short Bus";
                    break;
            }

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nI feel like I will be able to arrive at a prediction soon.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nFinally, please input the number of siblings you have.\nHalf- and step- siblings also count.");
            string sibInput = Console.ReadLine().ToLower();
            if (sibInput == "quit")
            {
                killSwitch();
            }
            else
            {
                numSiblings = int.Parse(sibInput);
            }
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

            Console.WriteLine("\nVery good.  I have all the information I need.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nCalculating . . .");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Calculating . . .");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Calculating . . .");
            System.Threading.Thread.Sleep(2000);
            if (yrsToRetire == "1,000,000" && moneyInBank == "0" && vacHome == "Pripyat, Ukraine" && xportType == "Short Bus") 
                {
                Console.WriteLine("\n\nSince you are incapable of following instructions: ");
                Console.WriteLine("{0} {1} will retire in {2} years with ", userFirst, userLast, yrsToRetire);
                Console.WriteLine("${0} in the bank, a vacation home in {1} and a {2}.", moneyInBank, vacHome, xportType);
            }
            else
            {
                Console.WriteLine("\n\n{0} {1} will retire in {2} years with ", userFirst, userLast, yrsToRetire);
                Console.WriteLine("${0} in the bank, a vacation home in {1} and a {2}.", moneyInBank, vacHome, xportType);
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nI hope you enjoyed your fortune.  Please run again if you want another fortune.");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("\nProgram Terminating . . .");

        }
    }
}
