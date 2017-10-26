using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking_random_101
{
    class Program
    {
        static void Main(string[] args)
        {
            //check random 0-100
            while (true)
            {   
                int magic_Number = new Random().Next(1,101);// 0-100
                Console.Write(" " + magic_Number);
                System.Threading.Thread.Sleep(magic_Number+101);
                if (magic_Number == 101)
                {
                    Console.ReadLine();
                    break;
                }
            }
            
        }
    }
}
