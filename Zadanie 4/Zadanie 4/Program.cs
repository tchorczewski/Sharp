using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        public static void Isodd(int number)
        {
            
            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
        }
        public static void canDivide(int number1,int number2)
        {
            int divided1;
            int divided2;
           ;
            Console.WriteLine("Sprawdzam czy pierwsze dwie liczby są podzielne przez siebie w obie strony");
            divided1 = number1 % number2;
            divided2 = number2 % number1;
            
            if (divided1 == 0 && divided2 == 0)
            {
                Console.WriteLine("Liczby te są podzielne przez siebie w obie strony");
            }
            else if(divided1 == 0 && divided2!=0)
            {
                Console.WriteLine("Pierwsza liczba jest podzielna prez drugą, ale druga nie jest podzielna przez pierwszą");
            }
            else if (divided1 != 0 && divided2 == 0)
            {
                Console.WriteLine("Pierwsza liczba nie jest podzielna przez drugą, ale liczba druga jest podzielna przez pierwszą");
            }
            else if(divided1 != 0 && divided2 != 0)
            {
                Console.WriteLine("Liczby te nie są przez siebie podzielne");
            }

        }
        
        static void Main(string[] args)
        {
            int var1;
            int var2;
                        Console.WriteLine("Podaj dwie liczby:");
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());
            
            Isodd(var1);
            Isodd(var2);
            canDivide(var1, var2);
            

        }
    }
}
