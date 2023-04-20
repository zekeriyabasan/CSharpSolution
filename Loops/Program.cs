using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            doWhile();
           
            if (isPrime(22) == true)
            {
                Console.WriteLine("this is a prime number.");
            }
            else
            {
                Console.WriteLine("this isn't prime number.");
            }


            Console.ReadLine();
        }

        private static bool isPrime(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    Console.WriteLine("{0} sayısı asal değildir.", number);
                    break; // döngü burda bitsin çünkü asal olmadığını bulduk.
                }
                
            }
            return result;
        }
        private static void doWhile()
        {
            int sayi = 10;

            do
            {
                Console.WriteLine("Şart Sağlansada sağlanmasada ilk cycle da do bloğu çalışır. sayi : {0}", sayi);
                sayi -= 10;

            } while (sayi == 0);
        }
    }
}
