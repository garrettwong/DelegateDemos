using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            IExample exampleToRun;

            Console.WriteLine(@"Which option?\n
1. Example1: Delegate as a Function
2. Multicasting
3. N/A");

            var choice = Console.ReadLine();

            exampleToRun = GetExampleByChoice(choice);

            exampleToRun.Run();
        }

        private static IExample GetExampleByChoice(string choice)
        {
            switch(choice)
            {
                case "1":
                    return new Example1();
                case "2":
                    return new Multicasting();
                default:
                    return new Example1();
            }
        }
    }
}
