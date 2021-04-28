using System;

namespace rekursiya_2
{
    using System;

    namespace rekursiya_2
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("vvedite pervoye celoye cislo!");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("vvedite vtoroye celoye cislo");
                int b = int.Parse(Console.ReadLine());

                NOD(a, b);
                Console.WriteLine($"NOD a i b ravno, { NOD(a, b)}");
            }

            static int NOD(int x, int y)
            {
                if (x == y)
                {
                    return x;
                }

                if (x > y)
                {
                    return NOD(x - y, y);
                }
                if (x < y)
                {
                    return NOD(x, y - x);
                }
                else
                {
                    return (NOD(x, y));
                }


            }
        }
    }
}
            
        

        
