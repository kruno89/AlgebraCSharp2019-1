﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2_jednako_kracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ovdje unesi duljinu 1. katete: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Ovdje unesi duljinu 2. katete: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Površina jednakokračnog trokuta je {0}.", Povrsina(a, b));
            Console.ReadKey();
        }

        static double Povrsina(double a, double b)
        {
            return (a * b) / 2;
        }
    }
}
