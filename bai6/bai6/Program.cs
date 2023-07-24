using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kl;
            int a =8; int b =10;
            kl = !(a != b ) && (a < 3);
            Console.WriteLine( "giá trị của kl là: " +kl );
            Console.ReadKey();
        }
    }
}
