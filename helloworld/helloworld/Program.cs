using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string sName = Console.ReadLine();

            Console.WriteLine("\n\rHello "+sName+"!");

            Console.WriteLine("\n\rPress any key to exit.");
            Console.ReadKey();
        }
    }
}
