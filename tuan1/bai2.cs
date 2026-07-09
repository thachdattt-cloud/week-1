using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class bai2
    {
        public static void xuly()
        {

            Console.WriteLine("nhap diem mon toan :");
            double toan = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem mon ly :");
            double ly = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem mon hoa");
            double hoa = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------------");
            Console.WriteLine("diem cua ban la :");
            Console.WriteLine("toan "+toan);
            Console.WriteLine("ly " + ly);
            Console.WriteLine("hoa " +hoa);
            double tb = (toan + ly + hoa) / 3;
            Console.WriteLine("diem trung binh cua ban la :" + tb.ToString("F4"));
        }
    }
}
