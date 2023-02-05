using System;

namespace EXERCISES_2
{
    internal class Program
    {
        public static void SolveQuadratic(double a, double b, double c)
        {

            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2, img;

            if(sqrtpart > 0)
            {
                x1 = (-b + Math.Sqrt(sqrtpart)) / (2*a);
                x2 = (-b - Math.Sqrt(sqrtpart)) / (2*a);

                Console.WriteLine("co 2 nghiem phan biet: {0,8:f4} or  {1,8:f4}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = Math.Sqrt(sqrtpart) / (2 * a);
                Console.WriteLine("vo nghiem: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
            }
           
            else

            {
                x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("co 1 nghiem kep: {0,8:f4}", x);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Tran Dinh Khanh_20IT271_20MC";
            int a, b, c;
            Console.Write("a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c : ");
            c = int.Parse(Console.ReadLine());

            SolveQuadratic(a, b, c);
            Console.ReadKey();

          
        }
    }
}
