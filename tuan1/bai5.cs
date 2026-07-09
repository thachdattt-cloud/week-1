using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class bai5
    {
        public static void xuly()
        {

            List<string> dssv =new List<string>();

            while (true)
            {
                Console.WriteLine("nhap lua chon cua ban (1.them sv / 2.xoa sinh vien / 3.hien thi sinh vien");
                int lc = int.Parse(Console.ReadLine());


                switch (lc) {

                    case 1:
                        Console.WriteLine("nhap ten sinh vien ");
                        string ten=Console.ReadLine();
                        dssv.Add(ten);
                        break;
                    case 2:
                        Console.WriteLine("nhap ten sinh vien can xoa");
                        string tenxoa=Console.ReadLine();
                        if (dssv.Remove(tenxoa))
                        {
                            Console.WriteLine("Đã xóa!");
                        }
                        else
                            Console.WriteLine("Không tìm thấy!");
                            break;


                    case 3:
                        Console.WriteLine("hien thi danh sach sinh vien");
                        foreach(string x in dssv)
                        {
                            Console.WriteLine(x);
                        }
                        break;


                        default: Console.WriteLine("chon lai lua chon ");
                        break;
                
                
                }








            }


        }
    }
}
