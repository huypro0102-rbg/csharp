using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b = 3;
            Console.WriteLine("nhập vào số nguyên a");
            a = int.Parse(Console.ReadLine());

            a -=b+3;
            Console.WriteLine("a = " + a);
            
           


            Console.ReadKey();
        }
    }
}
