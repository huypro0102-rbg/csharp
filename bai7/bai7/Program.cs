using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemtn;
            Console.WriteLine("nhập vào điểm tốt nghiệp:");
            diemtn = float.Parse(Console.ReadLine());

            if (diemtn > 7)
                Console.WriteLine("bạn đã đỗ tốt nghiệp", diemtn);
            else
                Console.WriteLine("bạn đã trượt", diemtn);
           
            Console.ReadKey();
        }
    }
}
