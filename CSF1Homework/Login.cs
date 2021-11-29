using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login!");


            bool validUser = true;
            bool userpswd = true;
            int attempts = 0;

            do
            {
                Console.Write("Enter your username: "); // 3 attempts
                string username = Console.ReadLine().ToUpper();
                if (username == "ERIC")
                {
                    attempts = 0;
                    validUser = false;

                    do
                    {
                        Console.Write("Enter password: "); //3 attempts
                        string userPassword = Console.ReadLine();

                        if (userPassword == "StarLord")
                        {
                            userpswd = false;
                            Console.WriteLine("You have been granted access");
                        }

                        else if (attempts < 2)
                        {
                            attempts++;
                            Console.WriteLine("Try Again");

                        }

                        else if (userPassword != "StarLord")
                        {
                            userpswd = false;
                            Console.WriteLine("Invalid password, Denied Access!");

                        }

                    } while (userpswd);
                }
                else if (attempts < 2)
                {
                    attempts++;
                    Console.WriteLine("Try again");
                }

                else
                {
                    validUser = false;
                    Console.WriteLine(username + ", You have been denied access!");

                }
            }
            while (validUser);
            

        }//end Main();
    }//end class
}//end namespace

