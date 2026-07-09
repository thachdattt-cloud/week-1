using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace tuan1
{
    internal class bai4
    {

        public static void xuly()
        {
            Console.WriteLine("nhap loai bang cuu chuong");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{n} * {i} = {n*i} \n");
            }

        }
    }
}
