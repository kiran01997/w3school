using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace stringformatting
{
    class A
    {

        static int ages(int a , int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int c = ages(5,6);
            Console.WriteLine(  c);

        }


    }
}