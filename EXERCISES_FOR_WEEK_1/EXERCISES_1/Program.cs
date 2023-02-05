using System;

namespace EXERCISES_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tran Dinh Khanh_20MC_20IT271";
            // bai toan viet chuong trinh nhap 2 so nguyen a,b in ra ket qua +,-,*,/
            int a;
            int b;
            string pt;
            // nhap so nguyen a
            Console.WriteLine("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());
            //nhap so nguyen b
            Console.WriteLine("Nhap so nguyen b: ");
            b = int.Parse(Console.ReadLine());
            // nhap phep tinh
            Console.WriteLine("Nhap phep tinh: ");
            pt = Console.ReadLine();
            Console.WriteLine("Ket qua:");
            //Kiem tra phep tinh
            if (pt == "+")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a + b = {0} ", a + b);
            }else if(pt == "-"){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"a - b = {a - b} ");
            }
            else if (pt == "*")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"a * b = {a * b} ");
            }
            else if (pt == "/")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"a / b = {a / b} ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Phep tinh khong hop le");
            }



            Console.ReadLine();
        }
    }

}
