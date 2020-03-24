using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_11_12
{
    class Program
    {
        
        public static void drawshape(int length, int widith, char sign)
        {

            Console.SetCursorPosition(1, 1);
            for(int i = 1; i < length; i++)
            {
                for(int j = 1; j < widith; j++)
                {
                    Console.SetCursorPosition(i+3,j+2);
                    
                    Console.WriteLine(sign);
                    
                    
                    
                        Console.WriteLine("\n");
                     
                }
                
            }
        }
        public static void factorial()
        {
            int liczba;
            int halp = 1;
            Console.WriteLine("Podaj liczbę jakiej silnia ma być policzona: ");
            liczba = int.Parse(Console.ReadLine());
            for (int i = 1; i < liczba; i++)
            {
                halp = halp * (i + 1);
                Console.WriteLine(halp);
            }
            Console.WriteLine(halp);
        }
        static void Main(string[] args)
        {
            int length;
            int widith;
            char sign;
            Console.WriteLine("Podaj jakie wymiary i z jakiego znaku ma się składać prostokąt");
            length = Convert.ToInt32(Console.ReadLine());
            widith = Convert.ToInt32(Console.ReadLine());
            sign = Convert.ToChar(Console.ReadLine());
            drawshape(length, widith, sign);
            factorial();
        }
    }
}
