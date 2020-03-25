using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_16_17
{
    class Program
    {
        public static void isdividable()
        {
            Console.WriteLine("Wypisuję wszystkie liczby do 100,które są podzielne przez 3 i 5");
            for(int i=0; i < 100; i += 15)
            {
                Console.WriteLine(i);
            }
            
        }
        public static void candivide(int var2)
        {
            Random random1 = new Random();
            
            int var1;
            
            
            Console.WriteLine("Generuję dwie liczby z zakresu 100-1000");
            var1 = random1.Next(100, 1001);
           
            Console.WriteLine("Wylosowana liczba 1 to: " + var1);
            Console.WriteLine("Wylosowana liczba 2 to: " + var2);
            if (var1 % var2 == 0)
            {
                Console.WriteLine("Liczba 1 jest podzielna przez 2");
            }
            else
            {
                Console.WriteLine("Liczba 1 nie jest podzielna przez 2");
            }
            if (var2 % var1 == 0)
            {
                Console.WriteLine("Liczba 2 jest podzielna przez 1");
            }
            else
            {
                Console.WriteLine("Liczba 2 nie jest podzielna przez 1");
            }
                 

        }
        static void Main(string[] args)
        {
            Random random2 = new Random();
            int var2;
            var2 = random2.Next(100, 1001)+1;//Bo tick zegara
            isdividable();
            candivide(var2);
        }
    }
}
