using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace String_vs_StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var watch2 = new Stopwatch();

            watch.Start();
            TheString();
            watch.Stop();
            Console.WriteLine("\nPerformance: {0}\n", watch.Elapsed);

            watch2.Start();
            TheStringBuilder();
            watch2.Stop();
            Console.WriteLine("\nPerformance: {0}\n", watch2.Elapsed);

            Console.ReadLine();
        }

        static void TheString()
        {
            string x = "Hello World.";
            Console.WriteLine("----String----");
            Console.WriteLine(x);

            x = "Hello World. Nevermind.";

            Console.WriteLine(x);

            x = "Hello World. Nevermind.\nWhat?";

            Console.WriteLine(x);

            x = "Hello World. Nevermind.";

            Console.WriteLine(x);

            x = "Hello World.";

            Console.WriteLine(x);

        }

        static void TheStringBuilder()
        {
            Console.WriteLine("----StringBuilder----");

            StringBuilder x = new StringBuilder("Hello World. ");

            Console.WriteLine(x);

            x.Append("NeverMind.");

            Console.WriteLine(x);

            x.AppendLine();

            x.Append("What?");

            Console.WriteLine(x);

            x.Replace("\nWhat?", "");

            Console.WriteLine(x);

            x.Replace("NeverMind.","");

            Console.WriteLine(x);

        }
    }


}
