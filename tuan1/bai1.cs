using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class bai1

    { 
        public static void xuly() {
            Console.WriteLine("hello world");
            Console.Write("nhap ten cua ban :");
            string ten = Console.ReadLine();
            Console.Write("nhap tuoi cua ban :");
            int tuoi = int.Parse(Console.ReadLine());

            Console.WriteLine("xin chao " + ten + " " + tuoi + " tuoi");
            Console.WriteLine("nam sinh cua ban la : " + (2026 - tuoi));
        }

    }
}
