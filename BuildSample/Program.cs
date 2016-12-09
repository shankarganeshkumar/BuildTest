using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            System.Console.WriteLine(x);
            int milliseconds = 10000;
            System.Threading.Thread.Sleep(milliseconds);
        }
    }
}
