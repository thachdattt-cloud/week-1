using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace tuan1
{
    internal class bai3
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
            Console.WriteLine("toan " + toan);
            Console.WriteLine("ly " + ly);
            Console.WriteLine("hoa " + hoa);
            double tb = (toan + ly + hoa) / 3;
            Console.WriteLine("diem trung binh cua ban la :" + tb.ToString("F2"));

            Console.WriteLine("chon cach phan loai cua ban(1.if else / 2.switch case / 3.switch expression)");
            int lc=int.Parse(Console.ReadLine());

            if (lc == 1)
            {


                if (tb >= 5.0 && tb < 7)
                {
                    Console.WriteLine("hoc luc cua ban thuoc loai trung binh");
                }
                else if (tb >= 7.0 && tb < 8.5)
                {
                    Console.WriteLine("hoc luc cua ban thuoc loai kha");
                }
                else if (tb >= 8.5)
                {
                    Console.WriteLine("hoc luc cua ban thuoc loai gioi");
                }
                else
                {
                    Console.WriteLine("ban dang yeu");
                }
            }
            else if(lc == 2)
            {
                Console.WriteLine("day la switch");
                switch (tb) {

                    case double n when (n >= 8.5):
                            Console.WriteLine("hoc luc cua ban thuoc loai gioi");
                        break;

                    case double n when (n >= 5 && n < 7):
                        Console.WriteLine("hoc luc cua ban thuoc loai trung binh");
                        break;

                    case double n when (n >= 7 && n < 8.5):
                        Console.WriteLine("hoc luc cua ban thuoc loai kha");
                        break;
                    default: Console.WriteLine("ban dang yeu");
                        break;

                }


            }
            else
            {
                Console.WriteLine("day la switch expression");
                string xeploai = tb switch
                {
                    
                    >=8.5 =>"ban thuoc laoi gioi",
                    >=5 and < 7 =>"ban thuoc loai trung binh",
                    >=7 and <8.5 =>"ban thuoc loai kha",
                    _ =>"ban thuoc loai yeu"

                };
                Console.WriteLine(xeploai);
            }
        }
    }
}
