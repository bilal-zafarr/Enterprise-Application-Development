using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace EADAssi1
{
    class Program
    {
        public class test
        {
            private static int count = 0;

            public static int getCount()
            {
                return count;
            }
            public test()
            {
                count++;
            }
            ~test()
            {
                count--;
            }
        }
        static void Main(string[] args)
        {
            test obj = new test();
            test obj2 = new test();
            test obj3 = new test();
            Console.WriteLine(Program.test.getCount());
        }
    }
}
