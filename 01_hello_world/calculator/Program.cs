using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculator
            Console.WriteLine("enter two numbers and i show division and multiplication");
            Console.WriteLine("");
            Console.Write("First number: ");
            string number_1 = Console.ReadLine();
            Console.Write("Second number: ");
            string number_2 = Console.ReadLine();

            int value_1 = int.Parse(number_1);
            int value_2 = int.Parse(number_2);

            int multi = value_1 * value_2;
            int divison = value_1 / value_2;

            Console.WriteLine("Multiplication of numbers " + value_1 + " and " + value_2 + " equals " + multi);
            Console.WriteLine("Division of number " + value_1 + " with " + value_2 + " equals " + divison);

            Console.ReadLine();





        }
    }
}
