using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
    class Program //nie chciało mi się już do każdej metody wsadzać sprawdzenia czy pole jest większe od 0 żeby to miało jakikolwiek sens 
    {
        public static void Kwadrat()
        {
            double a;
            double field;
            Console.WriteLine("Podaj długość boku kwadratu");
            a = Convert.ToDouble(Console.ReadLine());
            field = a * a;
            Console.WriteLine("Pole kwadratu wynosi: " + field);
        }
        public static void Prostokąt()
        {
            double a;
            double b;
            double field;
            Console.WriteLine("Podaj długości boków prostokąta:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            field = a * b;
            Console.WriteLine("Pole prostokąta wynosi: " + field);
        }

        public static void Trójkąt()
        {
            double a;
            double h;
            double pół = 0.5;
            double field;
            Console.WriteLine("Podaj długość boku i wysokość trójkąta");
            a = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            field = a * h * pół;
            Console.WriteLine("Pole trójkąta wynosi: " + field);
        }
        public static void Trapez()
        {
            double a;
            double b;
            double h;
            double pół;
            pół = 0.5;
            double field;
            Console.WriteLine("Podaj długość obu podstaw i wysokości trapezu");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            field = (a + b) * h * pół;
            Console.WriteLine("Pole trapezu wynosi: " + field);
        }
        public static void Koło()
        {
            double r;
            double Pi = Math.PI;
            double field;
            Console.WriteLine("Podaj długość promienia");
            r = Convert.ToDouble(Console.ReadLine());
            field = r * r * Pi;
            Console.WriteLine("Pole koła wynosi: " + field);
        }
        public static void Równoległobok()
        {
            double a;
            double h;
            double field;
            Console.WriteLine("Podaj długość boku i wysokość równoległoboku");
            a = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            field = a * h;
            Console.WriteLine("Pole równoległoboku wynosi: " + field);
        }
        public static void Romb()
        {
            double p;
            double q;
            double pół = 0.5;
            double field;
            Console.WriteLine("Podaj długość przekątnych");
            p = Convert.ToDouble(Console.ReadLine()); 
            q = Convert.ToDouble(Console.ReadLine());
            field = (p * q) * pół;
            Console.WriteLine("Pole rombu wynosi: " + field);
        }
        public static void Main(string[] args)
        {
            int listnumber;
            Console.WriteLine("Wybierz figurę z listy");
            Console.WriteLine(" 1.Kwadrat \n 2.Prostokąt \n 3.Trójkąt \n 4.Trapez \n 5.Koło \n 6.Równoległobok \n 7.Romb");
            listnumber = Convert.ToInt32(Console.ReadLine());
            if (listnumber > 7)
            {
                Console.WriteLine("Podano złą wartość proszę spróbować ponownie");
                listnumber = Convert.ToInt32(Console.ReadLine());
            }
            switch (listnumber)
            {
                case 1:
                    Kwadrat();
                    break;
                case 2:
                    Prostokąt();
                    break;
                case 3:
                    Trójkąt();
                    break;
                case 4:
                    Trapez();
                    break;
                case 5:
                    Koło();
                    break;
                case 6:
                    Równoległobok();
                    break;
                case 7:
                    Romb();
                    break;
                
            }
        }
    }
}



