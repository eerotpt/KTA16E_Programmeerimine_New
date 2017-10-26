using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excuses
{
    class Program
    {
        static void Main(string[] args)
        {
            var excuses = new[] { "screensaver võlus", "12345", "külmkapp oli väike", "kõik korras" };

            for (int i = 0; i < excuses.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(excuses[i]);
            }
            Console.ReadLine();
            
                foreach (var wordInArray in excuses) 
            { 
                Console.WriteLine(wordInArray);
                
            }
            Console.ReadLine();
        }
    }
}
