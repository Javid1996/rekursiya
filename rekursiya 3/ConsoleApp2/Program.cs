using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Console.WriteLine("vvedite cislo");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("vvedite stepen");
            int a = int.Parse(Console.ReadLine());
            Power(b, a);
            Console.WriteLine(Power(b,a));
            Console.ReadKey();
        }
        static int Power(int num, int s)
        {
           

            if (s == 1)
            {
                return num;
            }
            else if (s == 0)
            {
                return 1;
            }
            else
            {
                return num * Power(num, s-1);
            }
        }

       

    }   

}
