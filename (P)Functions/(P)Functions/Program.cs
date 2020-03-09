using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Zack Rosen", "MIS-3013", "03/09/2020");

            string calculation = "";
            double val1 = 0;
            double val2 = 0;
            string newcalc = "";



            do
            {
                Console.WriteLine("Please enter your first value.");
                val1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your second value.");
                val2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("What type of calculation would you like to do? (Addition/Subtraction/Multiplication/Division)");
                calculation = Console.ReadLine().ToUpper();


                if (calculation == "ADDITION")
                {
                    Console.WriteLine($"{val1} + {val2} = {add(val1,val2)}");
                }
                else if (calculation == "SUBTRACTION")
                {
                    Console.WriteLine($"{val1} - {val2} = {sub(val1, val2)}");
                }
                else if (calculation == "MULTIPLICATION")
                {
                    Console.WriteLine($"{val1} * {val2} = {mult(val1, val2)}");
                }
                else if (calculation == "DIVISION")
                {
                    Console.WriteLine($"{val1} / {val2} = {div(val1, val2)}");
                }
                else
                {
                    Console.WriteLine("Your input was not valid.");
                }


                Console.WriteLine("Would you like to enter a new calculation? (y/n)");
                newcalc = Console.ReadLine().ToLower();
            } while (newcalc == "y");

           
            Console.ReadKey();

        }


        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {

            Console.WriteLine($"{developerName} wrote this application for {className} on {dateOfWriting}");
            Console.WriteLine("Thank you for using this application!");
        }
        static double add(double val1, double val2)
        {
            return val1 + val2;
        }
        static double sub(double val1, double val2)
        {
            return val1 - val2;
        }
        static double mult(double val1, double val2)
        {
            return val1 * val2;
        }
        static double div(double val1, double val2)
        {
            return val1 / val2;
        }

    }
}
