﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prirucnik_5._3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n####    TABLICA MNOŽENJA    ####");
            Console.WriteLine("\n");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t", i * j);

                }
                Console.WriteLine("");
            }
            Console.ReadLine();

        }
    }
}
