
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("mời nhập vào số nguyên a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("bạn vừa nhập vào số {0}", a);
            if (a % 2 != 0)
                Console.WriteLine("số {0} là số lẻ", a);
            else
                Console.WriteLine("số {0} là số chẵn", a);



            Console.ReadKey();
        }
    }
}
