using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);

            string thisIsaString = "Ta Da";
            int countDown = 10;

            Console.WriteLine("Count Down" + thisIsaString);
            for (int i = 1; i <= countDown; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
