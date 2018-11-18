using Sample01.Utility;
using System;

namespace Sample01
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmd = " ls -l ".Bash();

            Console.WriteLine("Hello World!");
            Console.WriteLine(cmd);

        }
    }
}
