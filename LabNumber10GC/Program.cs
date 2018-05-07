using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabNumber10GC
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle grandCircle = new Circle();
            Console.WriteLine("Welcome to the Circle Tester");
            int count = 0;
            bool UserContinue = true;
            while (UserContinue)
            {
                count++;
                
                //preferably some validation

                grandCircle.Radius = IsDouble("Please enter the radius of the circle");
                
                
                
                Console.WriteLine("The circumference of the circle is: "
                    + grandCircle.CalculateCircumference());
                Console.WriteLine("The formatted cicumference of the circle is: " 
                    + grandCircle.CalculateFormattedCircumference());
                Console.WriteLine("The area of the circle is: "
                    + grandCircle.CalculateArea());
                Console.WriteLine("The formatted area of the circle is: " 
                    + grandCircle.CalculateFormattedArea());
                Console.WriteLine("Continue? y/n");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n" || choice.ToLower() == "no")
                {
                    UserContinue = false;
                    Console.WriteLine($"Goodbye. You created {count} Circle objects.");
                }
            }


            
        }

        public static double IsDouble(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, "^[0-9.]{1,}$"))
            {
                Console.WriteLine("Invalid input. Enter a valid number. " + prompt);
                input = Console.ReadLine();
            }
                return double.Parse(input);
            
        }
    }
}
