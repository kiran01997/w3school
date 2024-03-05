using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace method_learning
{
    class A
    {

        static int ages(int a = 10, int b = 11)
        {
            return a + b;

        }
        static double ages(double a , double b )
        {
            return a+ b;
        }
        static void Main(string[] args)
        {
            int c = ages(5, 6);
            Console.WriteLine(c);
            double   w = ages(10.5,10.6);
            Console.WriteLine(w);

        }


    }

}