using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace stringformatting
{
    class A
    {

        static int ages(int a = 10, int b = 11)
        {
            return a + b;

        }
        static int age(int x = 10, int y = 11)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int c = ages(5, 6);
            Console.WriteLine(c);
            int w = age();
            Console.WriteLine(  w);

        }


    }

}