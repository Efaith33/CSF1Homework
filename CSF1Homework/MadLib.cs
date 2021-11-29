using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MadLib!");


            Console.WriteLine("User, please enter some information below to do a Mad Lib Story about Vacations! ");

            Console.WriteLine("Adjective:");
            string inputAdj = Console.ReadLine();

            Console.WriteLine("Adjective:");
            string inputAdj2 = Console.ReadLine();

            Console.WriteLine("Noun:");
            string inputNoun = Console.ReadLine();

            Console.WriteLine("Noun:");
            string inputNoun2 = Console.ReadLine();

            Console.WriteLine("Plural Noun:");
            string inputPNoun = Console.ReadLine();

            Console.WriteLine("Game:");
            string inputGame = Console.ReadLine();

            Console.WriteLine("Plural Noun:");
            string inputPNoun2 = Console.ReadLine();





            Console.Write("A vacation is when you take a trip to some " + inputAdj + " place with your " + inputAdj2 + " family. Usually you go to some place that is near a/an " + inputNoun + " or up on a/an " + inputNoun2 + ". A good vacation place is one where you can ride " + inputPNoun + " or play " + inputGame + " or go hunting for " + inputPNoun2 + ".");
            Console.ReadLine();


        }//end Main()
    }//end class
}//end namespace
