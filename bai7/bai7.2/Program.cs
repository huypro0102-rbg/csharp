using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemtb;
            Console.WriteLine("nhập vào điểm trung bình:");
            diemtb = float.Parse(Console.ReadLine());

            if (diemtb >= 8)
                Console.WriteLine("xếp loại giỏi");
            else if (diemtb >= 6.5 && diemtb < 8)
                Console.WriteLine("xếp loại khá");
            else if (diemtb <= 5 && diemtb > 6.5)
                Console.WriteLine("xếp loại tb");
            else
                Console.WriteLine("xếp loại yếu");
            

            Console.ReadKey();
        }
    }
}
