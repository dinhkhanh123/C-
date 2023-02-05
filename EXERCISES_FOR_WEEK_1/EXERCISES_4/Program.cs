using System;

namespace EXERCISES_4
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Title = "Tran Dinh Khanh_20IT271_20MC";
            //Code duoc viet boi Tran Dinh Khanh
            Random rand = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int number;
            int n, m;
            string response;

            while (playAgain)
            {
                n = 0;
                m = 0;
                number = rand.Next(min, max + 1);
                // Tao vong lap cho nguoi nhap 7 lan de doan so
                while (n != number && m < 7)
                {
                    Console.Write($"Nhap so du doan ban tu {min} - {max} : ");
                    n = int.Parse(Console.ReadLine());
                    Console.WriteLine("So du doan: {0}", n);

                    if (n > number)
                    {
                        Console.WriteLine(n + "la so cao hon");
                    }
                    else if (n < number)
                    {
                        Console.WriteLine(n + "la so thap hon");
                    }
                    else
                    {
                        Console.WriteLine("Ban doan dung roi ");
                        return;
                    }
                    m++;
                }

          
                // Hien thi ket qua sau ki doan dung

                Console.WriteLine("Ban doan qua so lan cho phep");
                Console.WriteLine("So can doan : " + number);
                //Lua chon choi lai
                Console.WriteLine("Ban co muon choi lai Y/N");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else if (response == "N")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Cu phap khong hop le, xin moi nhap lai: ");
                    response = Console.ReadLine();
                    response = response.ToUpper();
                }


            }
            Console.WriteLine("Tro choi ket thuc");
            Console.ReadKey();

        }
    }
}
