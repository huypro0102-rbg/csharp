using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float a, b;
            a = 6;
            b = 9;

            Console.WriteLine("a = " +a);
            Console.ReadKey();

            a %= b;

            Console.WriteLine("a = " +b);


        }
    }
}
