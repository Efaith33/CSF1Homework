using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ATM");

            bool isLoggedIn = false;
            bool userPin = true;
            int attempts = 0;
            double deposit = 0;
            double withdrawl = 0;

            do
            {
                Console.Write("Enter users account number: ");
                string acctNmbr = Console.ReadLine();

                if (acctNmbr == "987654")
                {
                    Console.WriteLine();

                    do
                    {
                        Console.Write("Enter Pin for Acct: ");
                        string acctPin = Console.ReadLine();

                        if (acctPin == "1234")
                        {
                            userPin = false;
                            Console.WriteLine("Welcome!");
                        }

                        else if (attempts < 2)
                        {
                            attempts++;
                            Console.WriteLine("Invalid Pin, Try again...");
                        }

                        else if (acctPin != "1234")
                        {
                            userPin = false;
                            Console.WriteLine("Acct Locked");
                        }

                    } while (userPin);
                }

                else if (attempts < 2)
                {
                    attempts++;
                    Console.WriteLine("Invalid account number, try again. ");
                }

                else if (acctNmbr != "987654")
                {
                    Console.WriteLine("Acct Locked");
                }

                else 
                {
                    isLoggedIn = true;
                    Console.WriteLine("Access Denied");
                }
                
                } while (isLoggedIn);
            

        }//end Main();
    }//end class
}//end namespace

