using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int DoSoi = 200;
            const int DoLanh = 0;
            const double PI = 3.14;
            Console.WriteLine("độ đông là {0}", DoLanh);
            Console.WriteLine("độ sôi là {0}",DoSoi);
            Console.WriteLine("PI = {0}", PI);
            Console.ReadKey();


            float x, y;
            Console.WriteLine("nhập vào giá trị của x");
            x = float.Parse(Console.ReadLine());

            Console.WriteLine("nhập vào giá trị của y");
            y = float.Parse(Console.ReadLine());

            float a1 = x + y;
            float a2 = x - y;
            float a3 = x * y;
            float a4 = x / y;
            float a5 = x % y;

            Console.WriteLine("{0} + {1} = {2}",x,y,a1);
            Console.WriteLine("{0} - {1} = {2}",x,y,a2);
            Console.WriteLine("{0} * {1} = {2}",x,y,a3);
            Console.WriteLine("{0} / {1} = {2}",x,y,a4);
            Console.WriteLine("{0} % {1} = {2}",x,y,a5);

            Console.ReadKey();


        }
    }
}
