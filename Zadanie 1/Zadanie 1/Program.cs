using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        public static double Iloraz(double var1, double var2)
        {
            
            double iloraz;
            do
            {
                if (var1 == 0)
                {
                    Console.WriteLine("Podaj wartość numer jeden raz jeszcze");
                    var1 = isnumber(var1);
                }
                if (var2 == 0)
                {
                    Console.WriteLine("Podaj wartość numer dwa raz jeszcze");
                    var2 = isnumber(var2);

                }
            }
            while (var1 == 0 || var2 == 0);
            iloraz = var1 / var2;
            return iloraz;


        }
        public static double Suma(double var1, double var2)
        {
            double suma;
            suma = var1 + var2;
            return suma;

        }
        public static double Roznica(double var1, double var2)
        {
            double roznica;
            roznica = var1 - var2;
            return roznica;
        }
        public static double Iloczyn(double var1, double var2)
        {
            double iloczyn;
            iloczyn = var1 * var2;
            return iloczyn;
        }
        public static double isnumber(double var) 
        {
            
            while (true)
            {
                try
                {
                    var = Convert.ToDouble(Console.ReadLine());
                    
                    break;
                }
                catch (Exception) 
                {
                    Console.WriteLine("Podano błędny znak, spróbuj ponownie");
                }
            }
            return var;
        }
        
        public static void Kalkulatorek()
        {

            do
            {
                double var1 = 0,var2 = 0;
                int temp = 0;
                Console.WriteLine("1.Zsumuj wybrane liczby\n" +
                    "2.Odejmij podane liczby\n" +
                    "3.Pomnóż przez siebie podane liczby\n" +
                    "4.Podziel przez siebie podane liczby\n" );
                temp = Convert.ToInt32(isnumber(temp));
                
                    switch (temp)
                    {
                        case 1:
                            Console.WriteLine("Wybrałeś operacje dodawania");
                            Console.WriteLine("Podaj liczbę numer 1");
                            var1 = isnumber(var1); 
                            Console.WriteLine("Podaj liczbę numer 2");
                            var2 = isnumber(var2);
                            double suma = Suma(var1, var2);
                            Console.WriteLine("Wynik dodawania = " + suma);
                            break;
                        case 2:
                            Console.WriteLine("Wybrałeś operację odejmowania");
                            Console.WriteLine("Podaj liczbę numer 1");
                            var1 = isnumber(var1);
                            Console.WriteLine("Podaj liczbę numer 2");
                            var2 = isnumber(var2);
                            double roznica = Roznica(var1, var2);
                            Console.WriteLine("Wynik odejmowania = " + roznica);
                            break;
                        case 3:
                            Console.WriteLine("Wybrałeś operację mnożenia");
                            Console.WriteLine("Podaj liczbę numer 1");
                            var1 = isnumber(var1);
                            Console.WriteLine("Podaj liczbę numer 2");
                            var2 = isnumber(var2);
                            double iloczyn = Iloczyn(var1, var2);
                            Console.WriteLine("Wynik mnożenia = " + iloczyn);
                            break;
                        case 4:
                            Console.WriteLine("Wybrałeś operację dzielenia");
                            Console.WriteLine("Podaj liczbę numer 1");
                            var1 = isnumber(var1);
                            Console.WriteLine("Podaj liczbę numer 2");
                            var2 = isnumber(var2);
                            double iloraz = Iloraz(var1, var2);
                            Console.WriteLine("Wynik dzielenia = " + iloraz);
                            break;



                    }
                    Console.WriteLine("Wciśnij E aby wyjść, dowolny inny klawisz, żeby działać dalej ");
                


            }
            while (Console.ReadKey(true).Key != ConsoleKey.E); 
        }
        static void Main(string[] args)
        {
            
            Kalkulatorek();

        }
    }
}
