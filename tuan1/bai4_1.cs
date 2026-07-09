using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class bai4_1
    {
        public static void xuly()
        {
            Console.WriteLine("nhap so can kiem tra");
            int n=int.Parse(Console.ReadLine());

            bool snt = true;
            for(int i=2;i<= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    snt = false;
                    break;
                }
            }
            Console.WriteLine(snt ? $"{n} la so nguyen to " :$"{n} khong phai la so nguyen to");

        }
    }
}
