using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        public static void zadanie6(double var1, double var2, double var3)
        {
            double bezpiecznik = 0;
            if (var2 < var1)
            {
                bezpiecznik = var2;
                var2 = var1;
                var1 = bezpiecznik;

            }
            if (var3>var1 && var3 < var2)
            {
                Console.WriteLine("Liczba jest w przedziale");
            }
            else
            {
                Console.WriteLine("Liczba nie jest w przedziale");
            }
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("Podaj przedział od do i wartośc którą chcesz sprawdzić:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c= Convert.ToDouble(Console.ReadLine());
            zadanie6(a, b, c);

        }
    }
}
