using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_13_15
{
    class Program
    {
        public static void triangle(int row, char sign)
        {
            Console.SetCursorPosition(50, 1);
            for(int i = 0;i<row;i++)
            {
                for(int j = row - i;j>1;j--)
                {
                    Console.SetCursorPosition(50 + i, j);
                    Console.WriteLine(" ");
                }
                for(int j = 0; j <= i; j++)
                {
                    Console.SetCursorPosition(50 - i, j);
                    Console.WriteLine("*");
                }
                for (int j = row + i; j > 1; j--)
                {
                    Console.SetCursorPosition(50 + i, j);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("\n");
                //Zrobiłem pół więcej nie miałem siły głowić się nad obrazkiem
            }
        }
        public static void loops()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" " + i);
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(j);
                }
            }
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(" " + i);
                for (int j = 10; j > 0; j--)
                {
                    Console.WriteLine(j);
                }
            }


        }

        public static void emptyrectangle(int length, int widith, char sign)
        {

            Console.SetCursorPosition(30, 30);

            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= widith; j++)
                {
                    Console.SetCursorPosition(i + 3, j + 2);
                    if (i == 1 || i == length || j == 1 || j == widith)
                    {
                        Console.SetCursorPosition(i + 3, j + 2);
                        Console.WriteLine(sign);
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }

                    Console.WriteLine("\n");
                }
            }
        }
        
        static void Main(string[] args)
        {

            int lenght;
            int widith;
            char sign;
            int row;
            Console.WriteLine("Podaj długości boków i znak ramek prostokąta");
            lenght = int.Parse(Console.ReadLine());
            widith = int.Parse(Console.ReadLine());
            sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Podaj długość podstawy trójkąta");
            row = int.Parse(Console.ReadLine());
            emptyrectangle(lenght, widith, sign);
            triangle(row, sign);
            loops();
            
        }
    }
}
