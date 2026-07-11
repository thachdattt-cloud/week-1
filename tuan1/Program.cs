using tuan1;


namespace tuan1
{

    public class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                Console.WriteLine("--------------nhap bai muon chay-------------- ");
                Console.WriteLine("1.bai1 (hello world)");
                Console.WriteLine("2.bai2 (tinh diem trung binh)");
                Console.WriteLine("3.bai3 (xep loai hoc luc)");
                Console.WriteLine("4.bai4 (bang cuu chuong)");
                Console.WriteLine("5.bai4-1(check so nguyen to)");
                Console.WriteLine("6.bai5(list sinh vien don gian)");
                Console.WriteLine("6.bai6(list sinh vien cao hon)");
                Console.WriteLine("7. student(mini project)");
                Console.WriteLine("0.thoat");
                Console.WriteLine("------------------------------------------------");

                int lc=int.Parse(Console.ReadLine());

                switch (lc)
                {

                    case 1:
                        bai1.xuly();
                        break;
                    case 2:
                        bai2.xuly();
                        break;
                    case 3:
                        bai3.xuly();
                        break;
                    case 4:
                        bai4.xuly();
                        break;

                    case 5:
                        bai5.xuly();
                        break;
                    case 6:
                        bai6.xuly();
                        break;

                    case 7:
                        bai7 b7=new bai7();
                        b7.xuly();
                        break;

                    case 0:
                        return;
                      
                    default:
                        Console.WriteLine("moi ban chon lai");
                        break;
                
                }
            
            }
            
        }





    }
}






