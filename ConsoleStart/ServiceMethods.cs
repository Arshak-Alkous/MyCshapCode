using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStart
{
    public class ServiceMethods
    {
        public static double getAvarage(int x, int y, int z)
        {
            return (x + y + z) / 3.0;
        }
        public static int getLowestNum(int x, int y)
        {
            if (x < y) return x; else return y;
        }
        public static int getLowestNum(decimal x, decimal y)
        {
            if (x < y) return (int)x; else return (int)y;
        }
        public static double getSumOfDiffers(int x, int y, int z)
        {
            double avg = getAvarage(x, y, z);
            double difX = ((avg - x) >= 0) ? (avg - x) : -(avg - x);
            double difY = ((avg - y) >= 0) ? (avg - y) : -(avg - y);
            double difZ = ((avg - z) >= 0) ? (avg - z) : -(avg - z);
            return difX + difY + difZ;
        }
        public static void loopForprintB()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("B" + i);
            }
        }
        public static void loopForPrintNumberSeven()
        {
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(7 * i);
            }
        }
        public static void loopForprintB(int x)
        {
            for (int i = x; i < x+5; i++)
            {
                for (int j = 1; j < i-3 ; j++)
                {
                    Console.Write("B");
                }
                Console.WriteLine(i);
            }
        }
        //The method should return the value added tax (VAT) calculated.
        public static decimal calculatVAT(string product, decimal price)
        {
            decimal vat = 0.0m;
            switch (product)
            {
                case "music":
                    vat = price * 0.06m; break;
                case "food":
                    vat = price * 0.12m; break;
                case "alcohol":
                    vat = price * 0.25m; break;
                default:
                    Console.WriteLine("the product should be music or food or alcohol to calculat VAT"); break;
            }
            return vat;
        }
        // The method should return the full amount payable for the signee. 
        public static int getPricceOfGymMembership (int age, bool premium)
        {
            int price = 0;
            if (age < 19 || age > 64)
                price = premium ? 2500 : 2200;
            else price =premium ? 3400 : 3100;
            return price;
        }
        // The method returns the result of the operation
        public static double calculator(string operation, double num1, double num2)
        {
            double result = 0.0;
            switch (operation)
            {
                case "adding":
                    result = num1 + num2; break;
                case "subtracting":
                    result = num1 - num2; break;
                case "multiplying":
                    result = num1 * num2; break;
                case "dividing":
                    result = num1 / num2; break;
                default:
                    Console.WriteLine("Please enter the mathematical operation correctly"); break;
            }
            return result;
        }
        //  menu options method
        public static void menuOption(string option)
        {
            switch (option) 
            {
                case "help":Console.WriteLine("You chose Help");break;
                case "add":Console.WriteLine("You chose Add"); break;
                case "delete": Console.WriteLine("You chose Delete"); break;
                case "edit": Console.WriteLine("You chose Edit"); break;
                case "find": Console.WriteLine("You chose Find"); break;
                case "list": Console.WriteLine("You chose List"); break;
                default:Console.WriteLine("you don't chose a valid value");break;
            }
        }

    }
}
