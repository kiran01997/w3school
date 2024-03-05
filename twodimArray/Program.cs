using System;
namespace kiran
{
    class Arra
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, }, { 2, 3, } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j=0; j<a.GetLength(1);i++)
                    Console.WriteLine(a[i]);
            }
            {
                Console.WriteLine(i[1]);


            }
           


        }

    }
}