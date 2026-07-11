using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tuan1
{
    internal class Student
    {
        public int id { get; set; }
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string LopHoc { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public double diemtrungbinh()
        {
            double diemtb = (DiemToan + DiemLy + DiemHoa) / 3;
            return diemtb;
        }

        public string xeploai()
        {
            return diemtrungbinh() switch
            {
                >= 8.5 => "xep loai gioi",
                < 8.5 and >= 7 => "xep loai kha",
                < 7 and >= 5 => "xep loai trung binh",
                _ => "xep loai yeu"
            };
        }

        public override string ToString()
        {
            return $@"
ma sinh vien : {id}
ho va HoTen : {HoTen}
nam sinh : {NamSinh}
LopHoc : {LopHoc}
diem toan : {DiemToan}
diem ly : {DiemLy}
diem hoa : {DiemHoa}
diem trung binh : {diemtrungbinh().ToString("F2")}
xep loai : {xeploai()}
";
        }
    }

    public class bai7
    {
        List<Student> danhsach = new List<Student>();
        HashSet<int> masv = new HashSet<int>();

        public double nhapdiem(double min, double max)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double value) && value >= min && value <= max)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"gia tri phai tu {min} den {max}");
                }
            }
        }

        public int nhapsonguyen(int min)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int songuyen) && songuyen >= min)
                {
                    return songuyen;
                }
                else
                {
                    Console.WriteLine($"nam sinh phai tu {min}");
                }
            }
        }

        public void Them()
        {
            Student sv = new Student();
            Console.WriteLine("nhap thong tin sinh vien ");

            Console.Write("nhap ma sinh vien :");
            bool checkid = true;
            while (checkid)
            {
                sv.id = int.Parse(Console.ReadLine());
                if (masv.Contains(sv.id))
                {
                    Console.WriteLine("ma sinh vien da ton tai");
                }
                else
                {
                    checkid = false;
                    masv.Add(sv.id);
                }
               
            }

            Console.Write("nhap HoTen sinh vien :");
            bool checkname = true;
            while (checkname)
            {
                sv.HoTen = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(sv.HoTen))
                {
                    Console.WriteLine("vui long nhap day du HoTen sinh vien");
                }
                else
                {
                    checkname = false;
                }
            }

            Console.Write("nhap nam sinh :");
            sv.NamSinh = nhapsonguyen(2000);

            Console.Write("nhap LopHoc cua sinh vien :");
            sv.LopHoc = Console.ReadLine();

            Console.Write("nhap diem ly :");
            sv.DiemLy = nhapdiem(0, 10);

            Console.Write("nhap diem toan :");
            sv.DiemToan = nhapdiem(0, 10);

            Console.Write("nhap diem hoa :");
            sv.DiemHoa = nhapdiem(0, 10);

            danhsach.Add(sv);
            Console.WriteLine("Them sinh vien thanh cong");
            Console.WriteLine("--------------------------------------");
        }

        public void Xoa()
        {
            Console.WriteLine("nhap HoTen sinh vien can Xoa");
            string tencanxoa = Console.ReadLine();
            bool check = false;

            for (int i = danhsach.Count - 1; i >= 0; i--)
            {
                if (danhsach[i].HoTen == tencanxoa)
                {
                    danhsach.Remove(danhsach[i]);
                    check = true;
                }
            }

            if (check == true)
            {
                Console.WriteLine("da Xoa thanh cong sinh vien");
            }
            else
            {
                Console.WriteLine("khong tim thay sinh vien can Xoa");
            }
            Console.WriteLine("--------------------------------------");
        }

        public void DiemTrungBinhCaLop()
        {
            double diemtb_all = 0;
            for (int i = 0; i < danhsach.Count; i++)
            {
                diemtb_all += danhsach[i].diemtrungbinh();
            }
            Console.WriteLine("diem trung binh ca LopHoc la : " + diemtb_all);
            Console.WriteLine("--------------------------------------");
        }

        public void InDanhSach()
        {
            Console.WriteLine("thong tin sinh vien");
            foreach (var sv in danhsach)
            {
                Console.WriteLine(sv);
                Console.WriteLine("--------------------------------------");
            }
        }

        public void TimKiemChinhXacTheoTen()
        {
            Console.WriteLine("nhap HoTen can tim kiem :");
            string ten1 = Console.ReadLine();
            bool check2 = false;

            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].HoTen == ten1)
                {
                    check2 = true;
                    Console.WriteLine(danhsach[i]);
                }
            }

            if (check2 == false)
            {
                Console.WriteLine("khong tim thay HoTen sinh vien can tim");
            }
            Console.WriteLine("--------------------------------------");
        }

        public void SapXepDiemTangDan()
        {
            for (int i = 0; i < danhsach.Count - 1; i++)
            {
                for (int j = 0; j < danhsach.Count - 1 - i; j++)
                {
                    if (danhsach[j].diemtrungbinh() > danhsach[j + 1].diemtrungbinh())
                    {
                        var temp = danhsach[j];
                        danhsach[j] = danhsach[j + 1];
                        danhsach[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < danhsach.Count; i++)
            {
                Console.WriteLine(danhsach[i]);
            }
            Console.WriteLine("--------------------------------------");
        }

        public void DiemTrungBinhCaoNhat()
        {
            double max = 0;

            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].diemtrungbinh() >= max)
                {
                    max = danhsach[i].diemtrungbinh();
                }
            }

            Console.WriteLine("diem trung binh cao nhat la : " + max);
            Console.WriteLine($"thong tin cac sinh vien co so diem {max} la :");

            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].diemtrungbinh() == max)
                {
                    Console.WriteLine(danhsach[i]);
                }
            }
            Console.WriteLine("--------------------------------------");
        }

        public void DiemTrungBinhThapNhat()
        {
            double min = 10;

            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].diemtrungbinh() <= min)
                {
                    min = danhsach[i].diemtrungbinh();
                }
            }

            Console.WriteLine("diem trung binh thap nhat la : " + min);
            Console.WriteLine($"thong tin cac sinh vien co so diem {min} la :");

            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].diemtrungbinh() == min)
                {
                    Console.WriteLine(danhsach[i]);
                }
            }
            Console.WriteLine("--------------------------------------");
        }

        public void SoXepHang()
        {
            Dictionary<string, double> thongke = new Dictionary<string, double>
            {
                { "gioi", 0 },
                { "kha", 0 },
                { "trung binh", 0 },
                { "yeu", 0 }
            };

            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].xeploai() == "xep loai gioi")
                {
                    thongke["gioi"]++;
                }
                else if (danhsach[i].xeploai() == "xep loai kha")
                {
                    thongke["kha"]++;
                }
                else if (danhsach[i].xeploai() == "xep loai trung binh")
                {
                    thongke["trung binh"]++;
                }
                else
                {
                    thongke["yeu"]++;
                }
            }

            Console.WriteLine("thong tin so xep loai :");
            foreach (var x in thongke)
            {
                Console.WriteLine($"{x.Key} - {x.Value} (hoc sinh)");
            }
            Console.WriteLine("--------------------------------------");
        }

        public void SuaTheoMa()
        {
            Console.WriteLine("nhap ma sinh vien can sua");
            bool checkid2 = true;

            for (int i = 0; i < danhsach.Count; i++)
            {
                while (checkid2)
                {
                    int mamoi = int.Parse(Console.ReadLine());
                    if (danhsach[i].id == mamoi)
                    {
                        checkid2 = false;

                        Console.WriteLine("nhap HoTen moi");
                        string tenmoi = Console.ReadLine();
                        danhsach[i].HoTen = tenmoi;

                        Console.WriteLine("nhap nam sinh moi :");
                        int namsinhmoi = nhapsonguyen(2000);
                        danhsach[i].NamSinh = namsinhmoi;

                        Console.WriteLine("nhap HoTen LopHoc moi :");
                        string lopmoi = Console.ReadLine();
                        danhsach[i].LopHoc = lopmoi;

                        Console.WriteLine("nhap diem toan :");
                        double diemtoanmoi = nhapdiem(0,10);
                        danhsach[i].DiemToan = diemtoanmoi;

                        Console.WriteLine("nhap diem ly :");
                        double diemlymoi = nhapdiem(0,10);
                        danhsach[i].DiemLy = diemlymoi;

                        Console.WriteLine("nhap diem hoa :");
                        double diemhoamoi = nhapdiem(0,10);
                        danhsach[i].DiemHoa = diemhoamoi;

                        Console.WriteLine("sua thanh cong - thong tin vua sua la :");
                        Console.WriteLine(danhsach[i]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ko tim thay ma can sua - vui long nhap ma chinh xac");
                    }
                }
            }
        }

        public void TimKiemGanDungTheoTen ()
        {
            Console.WriteLine("nhap HoTen ban muon tim");
            string ten2=Console.ReadLine();
            for (int i = 0; i < danhsach.Count; i++)
            {
                if (danhsach[i].HoTen.Trim().ToLower().Contains(ten2.ToLower()))
                {
                    Console.WriteLine(danhsach[i]);
                }

            }
            Console.WriteLine("--------------------------------------");
        }

        public void xuly()
        {
            while (true)
            {
                Console.WriteLine("-----------------------DANH SACH TUY CHON-----------------------");
                Console.WriteLine("\t\t1.Them sinh vien");
                Console.WriteLine("\t\t2.Xoa sinh vien");
                Console.WriteLine("\t\t3.tinh diem trung binh cua LopHoc");
                Console.WriteLine("\t\t4.in danh sach sinh vien");
                Console.WriteLine("\t\t5.tim kiem sinh vien theo HoTen");
                Console.WriteLine("\t\t6.sap xep sinh vien theo danh sach tang dan so diem");
                Console.WriteLine("\t\t7.tim sinh vien co diem cao nhat");
                Console.WriteLine("\t\t8.tim sinh vien co diem thap nhat");
                Console.WriteLine("\t\t9.thong ke xep loai");
                Console.WriteLine("\t\t10.sua thong tin sinh vien theo ma");
                Console.WriteLine("\t\t11.tim kiem gan dung HoTen sinh vien");
                Console.WriteLine("\t\t12.thoat");
                Console.WriteLine("chon phuong an muon chon : ");
                Console.WriteLine("---------------------------------------------------------------");

                int lc = int.Parse(Console.ReadLine());

                switch (lc)
                {
                    case 1:
                        Them();
                        break;

                    case 2:
                        Xoa();
                        break;

                    case 3:
                        DiemTrungBinhCaLop();
                        break;

                    case 4:
                        InDanhSach();
                        break;

                    case 5:
                        TimKiemChinhXacTheoTen();
                        break;

                    case 6:
                        SapXepDiemTangDan();
                        break;

                    case 7:
                        DiemTrungBinhCaoNhat();
                        break;

                    case 8:
                        DiemTrungBinhThapNhat();
                        break;

                    case 9:
                        SoXepHang();
                        break;

                    case 10:
                        SuaTheoMa();
                        break;
                    case 11:
                        TimKiemGanDungTheoTen();
                        break;
                    case 12:

                        return;

                    default:
                        Console.WriteLine("moi ban chon lai phuong an phu hop !");
                        break;
                }
            }
        }
    }
}