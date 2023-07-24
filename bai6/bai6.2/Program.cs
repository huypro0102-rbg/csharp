using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=1; int b=2;
            int c = a++ - ++b + 1;
            Console.WriteLine("a = " +a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            Console.ReadKey();

        }
    }
}
