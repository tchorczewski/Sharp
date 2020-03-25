using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania7_9
{
    class Program
    {
        public static void calculate(double angle)
        {
            double sinus;
            double cosinus;
            double tangens;
            double ctg;
            double radians;
            radians = angle * (Math.PI / 180);
            sinus = Math.Sin(radians);
            Console.WriteLine("Sin:" + sinus);
            cosinus = Math.Cos(radians);
            Console.WriteLine("Cos:" + cosinus);
            tangens = Math.Tan(radians);
            Console.WriteLine("Tan:" + tangens);
            ctg = 1 / tangens;
            Console.WriteLine("Ctg:" + ctg);
            
        }
        public static void showc(char sign, int count)
        {
            for (int i = 0; i<count; i++)
            {
                Console.WriteLine(sign);
            }
        }
        public static void trigonometry()
        {
            int angle;
            Console.WriteLine("Podaj dla jakich kątów chcesz zobaczyć wartości, do wyboru masz\n 1.0 \n 2.30 \n 3.90 \n 4.120 \n (Wartości podane w stopniach)");
            Console.WriteLine("Tam gdzie występuje znak ? oznacza to że wartość nie istnieje");
            angle = int.Parse(Console.ReadLine());
            double radians = angle * (Math.PI / 180);
            if (angle != 0 && angle != 30 && angle != 90 && angle != 120)
            {
                Console.WriteLine("Nie posiadam takich wartości podaj ponownie");
                angle = int.Parse(Console.ReadLine());
            }
            else if(angle == 0)
            {
                calculate(0);

            }
            else if (angle == 30)
            {
                calculate(30);
            }
            else if (angle == 90)
            {
                calculate(90);
            }
            else if (angle == 120)
            {
                calculate(120);
            }

        }
        public static void square(double side)
        {
            double field;
            field = side * side;
            Console.WriteLine("Pole kwadratu jest równe:"+field);
        }
        static void Main(string[] args)
        {
            char sign;
            int count;
            double side;
            Console.WriteLine("Podaj jakiś znak");
            sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj ile razy chcesz wyświetlić ten znak");
            count = Convert.ToInt32(Console.ReadLine());
            showc(sign, count);
            Console.WriteLine("Podaj długość boku kwadratu:");
            side = Convert.ToDouble(Console.ReadLine());
            square(side);
            trigonometry();
        }
    }
}
