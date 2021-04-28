using System;

namespace rekursiya_5
{
    enum Dayofweek

    {

        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели:");
            var n = Proverka();
            Console.WriteLine((Dayofweek)((n)));
        
           
        } 

        static int Proverka() 
        {
            int prov;
            string num = Console.ReadLine();
            for(; ; ) 
            {
                if (Int32.TryParse(num, out prov) && prov < 7 && prov > 0)
                {
                    return prov;
                }
            else
                {
                    Console.WriteLine("введите корректные данные");
                    num = Console.ReadLine();       
                }
            
            
            
            }
        }
        

       

    }
}
