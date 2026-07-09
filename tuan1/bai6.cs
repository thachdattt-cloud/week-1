using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tuan1
{
    internal class student
    {
        public string ten {  get; set; }
        public int tuoi {  get; set; }
        public double diemtb {  get; set; }

        public string xeploai()
        {
            return diemtb switch
            {
                >= 8.5 => "xep loai gioi",
                < 8.5 and >= 7 => "xep loai kha",
                > 5 and < 7 => "xep loai trung binh",
                _ => "xep loai yeu"

            };
        }

        public override string ToString()
        {
            return $@"ten : {ten}
tuoi :{tuoi}
diem :{diemtb}
xep loai :{xeploai()}";
        }


    }

    public class bai6
    {

        public static void xuly()
        {

            List<student> danhsach = new List<student>();

            while (true)
            {

                Console.WriteLine("\t\tchon phuong an muon chon") ;
                Console.WriteLine("\t\t1.them sinh vien");
                Console.WriteLine("\t\t2.xoa sinh vien");
                Console.WriteLine("\t\t3.tinh diem trung binh cua lop");
                Console.WriteLine("\t\t4.in danh sach sinh vien");
                Console.WriteLine("\t\t5.tim kiem sinh vien theo ten");
                Console.WriteLine("\t\t6.sap xep sinh vien theo danh sach tang dan so diem");
                Console.WriteLine("\t\t7.tim sinh vien co diem cao nhat");
                Console.WriteLine("\t\t8.tim sinh vien co diem thap nhat");
                Console.WriteLine("\t\t9.thong ke xep loai");
                Console.WriteLine("\t\t10.sua thong tin sinh vien theo ten");
                Console.WriteLine("\t\t11.thoat");
                int lc = int.Parse(Console.ReadLine());
                student sv = new student();
                switch (lc)
                {
                 
                    case 1:


                        bool check1 = true;
                        
                       
                        Console.WriteLine("nhap ten sinh vien");
                        while (check1)
                        {
                            sv.ten = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(sv.ten))
                            {
                                Console.WriteLine("vui long nhap ten sinh vien");
                               
                            }
                            else
                            {
                                check1 = false;
                            }
                        }
                        Console.WriteLine("nhap tuoi cua sinh vien");
                        bool check= true;
                        while (check)
                        {
                            sv.tuoi = int.Parse(Console.ReadLine());
                            if(sv.tuoi > 0)
                            {
                                check = false;
                            }
                            else
                            {
                                Console.WriteLine("tuoi la 1 so lon hon 0 vui long nhap lai");
                            }

                        }
                        Console.WriteLine("Nhap diem trung binh ");
                        sv.diemtb = double.Parse(Console.ReadLine());
                        danhsach.Add(sv);
                        Console.WriteLine("them thanh cong");
                        Console.WriteLine("------------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("nhap ten sinh vien can xoa");
                        string tenmoi=Console.ReadLine();
                        bool daxoa = false;
                        for (int i=danhsach.Count-1;i>=0;i--) {

                            
                                if (danhsach[i].ten == tenmoi)
                                {
                                danhsach.Remove(danhsach[i]);
                                    daxoa = true;

                                }


                            }
                            if (daxoa == true)
                            {
                                Console.WriteLine("da xoa sinh vien thanh cong");
                            }
                            else
                            {
                                Console.WriteLine("khong tim thay sinh vien can xoa");
                            }

                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:

                        double diemtrungb;
                        double tongdiem = 0;
                        foreach(student x in danhsach)
                        {
                            tongdiem += x.diemtb;


                        }
                        Console.WriteLine("diem trunb binh cua lop la : "+(tongdiem/danhsach.Count).ToString("F2"));
                        Console.WriteLine("------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("thong tin cac thanh vien :");
                        foreach(student x in danhsach)
                        {
                            Console.WriteLine(x.ten +" / "+x.tuoi +" / "+x.diemtb+" / "+ x.xeploai());
                        }
                        Console.WriteLine("------------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("nhap ten sinh vien can tim kiem");
                        string ten1=Console.ReadLine();
                        bool find = false;
                        for(int i=0;i<danhsach.Count;i++)
                        {
                            if (danhsach[i].ten == ten1)
                            {
                                find = true;
                                Console.WriteLine("sinh vien can tim la : " + danhsach[i]);
                                
                            }
                        }
                        if (find==false)
                        {
                            Console.WriteLine("khong thay sinh vien can tim");
                        }
                        Console.WriteLine("------------------------------------");
                        break;

                    case 6:

                        Console.WriteLine("thong tin diem tang dan");
                        for(int i = 0; i < danhsach.Count - 1; i++)
                        {
                            for(int j = 0; j < danhsach.Count - 1-i; j++)
                            {

                                if (danhsach[j].diemtb > danhsach[j + 1].diemtb)
                                {
                                    var temp = danhsach[j];
                                    danhsach[j] = danhsach[j + 1];
                                    danhsach[j + 1] = temp;
                                }
                            }
                        }

                        Console.WriteLine("sap xep xong");
                        for (int i = 0; i < danhsach.Count; i++)
                        {

                            Console.WriteLine(danhsach[i]);
                        }
                        Console.WriteLine("------------------------------------");
                        break;
                    case 7:
                        Console.WriteLine("thong tin sinh vien co diem cao nhat");

                        double max = -1;
                        for(int i = 0; i < danhsach.Count; i++)
                        {
                            if (danhsach[i].diemtb > max)
                            {
                                max = danhsach[i].diemtb;
                            }
                        }
                        Console.WriteLine(max);
                        for (int i = 0;i < danhsach.Count; i++)
                        {
                            if (danhsach[i].diemtb == max)
                            {
                                Console.WriteLine(danhsach[i]);
                            }
                        }


                        break;

                    case 8:
                        Console.WriteLine("thong tin sinh vien co diem thap nhat");

                        double min = 10;
                        for (int i = 0; i < danhsach.Count; i++)
                        {
                            if (danhsach[i].diemtb < min)
                            {
                                min = danhsach[i].diemtb;
                            }
                        }
                        Console.WriteLine(min);
                        for (int i = 0; i < danhsach.Count; i++)
                        {
                            if (danhsach[i].diemtb == min)
                            {
                                Console.WriteLine(danhsach[i]);
                            }
                        }


                        break;
                    case 9:
                        Dictionary<string, double> thongke = new Dictionary<string, double>
                        {
                            {"gioi" , 0 },{ "kha",0},{"trung binh",0},{"yeu",0}
                        };

                        foreach (var tk in danhsach)
                        {
                            string loai = tk.xeploai();
                            if(loai == "xep loai gioi")
                            {
                                thongke["gioi"]++;
                            }
                            else if (loai == "xep loai kha") thongke["kha"]++;
                            else if (loai == "xep loai trung binh") thongke["trung binh"]++;
                            else thongke["yeu"]++;
                        }

                        foreach(var tk1 in thongke)
                        {
                            Console.WriteLine($"{tk1.Key} - {tk1.Value} sinh vien");
                        }





                        break;

                    case 10:
                        Console.WriteLine("nhap ten sinh vien can sua");
                        string tenmoi1=Console.ReadLine();
                        for(int i = 0;i < danhsach.Count; i++)
                        {
                            if (danhsach[i].ten == tenmoi1)
                            {
                                Console.WriteLine("ten moi ");
                                string tenmoi2=Console.ReadLine();
                                danhsach[i].ten = tenmoi2;
                                Console.WriteLine("nhap tuoi : ");
                                int tuoimoi=int.Parse(Console.ReadLine());
                                danhsach[i].tuoi = tuoimoi;
                                Console.WriteLine("nhap diem trung binh ");
                                double diemtbmoi=double.Parse(Console.ReadLine());
                                danhsach[i].diemtb=diemtbmoi;
                                
                            }
                           
                        }
                        Console.WriteLine("da sua thanh cong");
                        break;

                    case 11:
                        break;
                    default:
                        Console.WriteLine("moi ban chon lai !");
                        break;



                }

            }

        }

    }



}
