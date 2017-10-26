using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_while
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string entry;
            int magic_Number = new Random().Next(101);
            Console.Write("Quess a number from 1 to 99: ");

            while (true)
            {

                entry = Console.ReadLine();
                int entry_int = int.Parse(entry);
                if (entry_int == magic_Number)
                {
                    Console.WriteLine("Right " +" "+ entry_int +" "+ entry);
                    Console.ReadLine();
                    break;
                }
                else if (entry_int < magic_Number)
                {
                    Console.WriteLine("number is bigger ");
                }
                else
                {
                    Console.WriteLine("number is smaller");
                }

            }
                    Console.ReadLine();
                
                
            }                
    }
}
