using System;

namespace EXERCISES_3
{
    internal class Program
    {
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); ++i)
            {
                if (n % i == 0)
                    return false;
            }
            return n > 1;
        }

        static void Main(string[] args)
        {
            Console.Title = "Tran Dinh Khanh_20IT271_20MC";
           
            int a;
            Console.Write("Nhap a: ");
            a = int.Parse(Console.ReadLine());

            if (isPrime(a))
            {
                Console.WriteLine("a la so nguyen to");
            }
            else
                Console.WriteLine("a khong phai la so nguyen to");
          
            Console.ReadKey();
        }
        

        }
    }
