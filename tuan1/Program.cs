using tuan1;


namespace tuan1
{

    public class Program
    {
        static void Main(string[] args)
        {
            while (true) {

                Console.WriteLine("nhap bai muon chay ");
                Console.WriteLine("1.bai1");
                Console.WriteLine("2.bai2");
                Console.WriteLine("3.bai3");
                Console.WriteLine("4.bai4");
                Console.WriteLine("5.bai5");
                Console.WriteLine("6.bai6");
                Console.WriteLine("7. student");

                int lc=int.Parse(Console.ReadLine());

                switch (lc) {
                    case 7:
                        bai7 b7=new bai7();
                        b7.xuly();
                        break;
                
                }
            
            }
            
        }





    }
}






