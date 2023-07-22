using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int so = 0;
            //    float DiemTrungBinh = 9.5f;
            //    string name = "hoàng";
            //    byte tuoi;
            //    Console.WriteLine("so luong la: {0}", so);
            //    Console.WriteLine("diem trung binh la: {1} ", so,DiemTrungBinh);
            //    Console.ReadKey();

            //    int a = 1;
            //    int b = 2;
            //    int c = 3;
            //    int d = 4;
            //    float z = a+b+c+d/4;
            //    float z2 = (float)a / b; 
            //    Console.WriteLine("giá trị của z là" + z);
            //    Console.WriteLine("giá trị của z2 là" + z2);
            //    Console.ReadKey();

            //    byte x = 255;
            //    int y = x;

            //    int k = 20;
            //    Console.WriteLine("giá trị của k là" + k);
            //    byte l = (byte)k;
            //    Console.WriteLine("giá trị của l là" + l);
            Console.OutputEncoding = Encoding.UTF8;
            string hoTen;
            float diemToan;
            float diemVan;

            Console.WriteLine("nhập tên");
            hoTen = Console.ReadLine();

            Console.WriteLine("nhập điểm toán:");
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("nhập điểm văn:");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("học sinh {0} có điểm toán là {1}, điểm văn là {2}", hoTen,
                diemToan,diemVan);

            Console.ReadKey();



            var y = 233;
            Console.WriteLine("kiểu dữ liệu của y là {0}", y.GetType().ToString());
            Console.ReadKey();
            var k = "hoàng";
            Console.WriteLine("kiểu dữ liệu của k là {0}", k.GetType().ToString());
            var l = "6.3";
            Console.WriteLine("kiểu dữ liệu của l là {0}",l.GetType().ToString());
        }
    }
}
