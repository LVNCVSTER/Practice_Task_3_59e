using System;

namespace Task3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double x, y;
            bool answer;
            Console.WriteLine("Введите x");
            while(!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите корректное значение x");
            }
            Console.WriteLine("Введите y");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Введите корректное значение y");
            }
            if (x > 1 || x < -2 || y > 1 || y < -1)
            {
                answer = false;
                
            }
            else
            {
                if (x > 0)
                {
                    answer = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
                    
                }
                else
                {
                    
                        if (y <= (x / 2) + 1 && y >= ((-x / 2) - 1) && x==0)
                        {
                            answer = true;
                            
                        }
                        else
                        {
                            answer = false;
                            
                        }
                    

                }
            }
            if (answer == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Принадлежит");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не принадлежит");
                Console.ResetColor();
            }

        }
    }
}
