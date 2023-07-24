using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float r, dt, cv;
            const float PI = 3.14f;
            Console.WriteLine("mời nhập vào bán kính của đường tròn: ");
            r = float.Parse(Console.ReadLine());
          
            cv=2 * PI * r;
            dt=PI * r *r;

            Console.WriteLine("diện tích hình tròn là:" +dt);
            Console.WriteLine("chu vi hình tròn là:" + cv);
            
            Console.ReadKey();



        }
    }
}
