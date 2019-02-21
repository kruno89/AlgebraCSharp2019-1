using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = 5;
            y = x + 3;
            Console.WriteLine("broj x je:" + x);
            Console.WriteLine("broj y je:" + y);
            Console.WriteLine("Njihov zbroj je:" + (x + y));

            //Ne zatvaraj dok se ne stisne key
            Console.ReadKey();
        } 
    }
}
