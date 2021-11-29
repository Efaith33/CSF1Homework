using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FruitLoop2!");
            /*   
                 string[] fruit = { "Apples", "Pears", "Strawberries", "Bannanas", "Grapes", "Blueberries" };
                 for (int i = 0; i < fruit.Length; i++)
                 {
                    Console.WriteLine(fruit[i]);
                 }
            */

              string[] fruit = new string[6];

            fruit[0] = "Apples";
            fruit[1] = "Pears";
            fruit[2] = "Strawberries";
            fruit[3] = "Bannanas";
            fruit[4] = "Grapes";
            fruit[5] = "Blueberries";

            Console.WriteLine($"{fruit[0]} are in the index of zero ");
            Console.WriteLine();

            Console.WriteLine($"{fruit[1]} are in the index of 1 ");
            Console.WriteLine(".");

            Console.WriteLine($"{fruit[2]} are in the index of 2 ");
            Console.WriteLine("..");

            Console.WriteLine($"{fruit[3]} are in the index of 3 ");
            Console.WriteLine("...");

            Console.WriteLine($"{fruit[4]} are in the index of 4 ");
            Console.WriteLine("....");

            Console.WriteLine($"{fruit[5]} are in the index of 5 ");
            Console.WriteLine(".....");


        }//end Main()
    }//end class
}//end namespace
