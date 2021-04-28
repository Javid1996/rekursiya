using System;

namespace rekursiya_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            Console.WriteLine("vvedite minimalnoe cislo");

            
                for (; ; )
                {
                    string message = Console.ReadLine();
                    if (Int32.TryParse(message, out first) && first > 0)
                    {

                        break;
                    }
                    {
                      
                        Console.Write(" pojaluysta vvedite polojitelnoye cislo!");
                    }
                }


                Console.WriteLine("vvedite maksimalnoe cislo");
                for (; ; )
                {
                    string message2 = Console.ReadLine();
                    if (Int32.TryParse(message2, out second) && second > 0)
                    {

                        break;
                    }
                    {
                        
                        Console.Write(" pojaluysta vvedite polojitelnoye cislo!");
                    }
                }
                
               
            
               

            
                 int main_message = Range(first, second);
                Console.WriteLine($"Summa cisel v diapazone {main_message - second}");
                Console.ReadKey();

            
        }
        static int Range(int first, int second)
        {
            
                if (first == second)
            {
                return 0;
            }
            else
            {
                return second + Range(first, second - 1);
            }

        }
    }
}
