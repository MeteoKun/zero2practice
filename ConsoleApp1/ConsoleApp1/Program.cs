using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Add(7,14, 10));

            Console.WriteLine("Hello");

        }
    }

    static class Math
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Add(int a, int b, string c)
        {
            return a;
        }
    }

}



