using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Converter!");
            Console.WriteLine("is this working");

            Console.WriteLine("User, input a temp in Celsius: ");
            double userCelsius = double.Parse(Console.ReadLine());           
            Console.WriteLine(userCelsius + " degrees celsuis converts to " + (userCelsius * 9 / 5 + 32) + " degrees fahrenheit");
            Console.WriteLine();

            Console.WriteLine("User, input a temp in fahrenheit: ");
            double userFahrenheit =double.Parse(Console.ReadLine());           
            Console.WriteLine(userFahrenheit + " degrees farhenheit converts to " + (userFahrenheit - 32) * 5 / 9 + " degrees celsius");
            Console.WriteLine();

            bool repeat = true;
            Console.WriteLine("USER MENU: ");

            do
            {
                Console.WriteLine("User, choose which conversion you'd like to do! ");
                Console.WriteLine(@"
A) Celsius to Farenheit
B) Farenheit to Celsius
");
                string userChoice = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (userChoice)

                {
                    case "A":
                        Console.WriteLine("User, enter a degree in celsuis....");
                        double input1 = double.Parse(Console.ReadLine());
                        Console.WriteLine(input1 + " degrees celsuis converts to " + (input1 * 9 / 5 + 32) + " degrees fahrenheit \n");
                        break;

                    case "B":
                        Console.WriteLine("User, enter a degree in fahrenheit....");
                        double input2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(input2 + " degrees celsuis converts to " + (input2 * 9 / 5 + 32) + " degrees fahrenheit \n");
                        break;


                    default:
                        Console.WriteLine("Invalid Response! ");
                        Console.WriteLine();
                        repeat = false;
                        break;

                }//end switch
                
                Console.WriteLine("Do you have any other conversions to do? Y/N: ");
                string useranswer = Console.ReadLine().ToUpper();

                if (useranswer == "Y" || useranswer == "YES")
                {
                    repeat = true; 
                }
                else
                {
                    repeat = false;
                    Console.WriteLine("Thank you for your temps");
                }       

            } while (repeat);
        


           
           

        }//end Main();
    }//end class
}//end namespace
