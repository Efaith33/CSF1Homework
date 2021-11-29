using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {    
            Console.WriteLine("FruitLoop1");


            //Declare and initialize an array of any 6 fruit names( as text). Set
            // up a FOR loop and iterate thru them (displaying each value in the console.)

            string[] fruit = { "Apples", "Pears", "Strawberries", "Bannanas", "Grapes", "Blueberries" };

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }//end Main()
    }//end class
}//end namespace