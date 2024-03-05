using System;
using System.Threading.Channels;

namespace stringformatting
{
    class A
    {
        static void Main(string[] args)
        {
            string[] Names = { "kiran", "rajan", "pawan" };
            Array.Sort(Names);
            foreach (string i in Names)
            { Console.WriteLine(i); }
        }

       
    }
}