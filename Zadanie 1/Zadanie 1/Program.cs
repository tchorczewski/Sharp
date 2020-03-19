using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        public static void Kalkulatorek(int variable1, int variable2)
        {
          int suma;
        int roznica;
        int iloraz;
         int iloczyn;
        suma = variable1 + variable2;
            roznica = variable1 - variable2;
            iloraz = variable1/variable2;
            iloczyn = variable1* variable2;

            Console.WriteLine("Twoje wyniki: ");
            Console.WriteLine("Suma " + suma);
            Console.WriteLine("Roznica " + roznica);
            Console.WriteLine("Iloczyn " + iloczyn);
            Console.WriteLine("Iloraz " + iloraz);

                       
           
        }
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Podaj dwie liczby:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Kalkulatorek(a, b);

        }
    }
}
