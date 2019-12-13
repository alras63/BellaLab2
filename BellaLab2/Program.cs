using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellaLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int aInt = 6;

            int bInt = 4;
            Console.WriteLine("Генерируем случайную матрицу с параметрами a={0}, b={1}", aInt, bInt);
            Console.ResetColor();
  
            int[,] matrix = GenerateMatrixFunc(aInt, bInt);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выводим сгенерированную матрицу");
            Console.ResetColor();

            for (var i = 0; i < aInt; i++)
            {
                for (var j = 0; j < bInt; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выберите строку, сумма чисел которой будет умножаться на сумму чисел главной диагонали:  ");
            Console.ResetColor();
            string numStr;
            int numInt;

            numStr = Console.ReadLine();

            while(!int.TryParse(numStr, out numInt))
            {
                Console.WriteLine("Неверно! Введите число");
                numStr = Console.ReadLine();
                
            } 


            int sumDiag = 0;
            int linesum = 0;

            for (var i = 0; i < aInt; i++)
            {
                for (var j = 0; j < bInt; j++)
                {
                    if(i == j)
                    {
                        sumDiag += matrix[i, j];
                    }

                    if(i == numInt)
                    {
                        linesum += matrix[i, j];
                    }
                   
                }
            }

            Console.WriteLine("Сумма диагонали: {0}; Сумма линии: {1}", sumDiag, linesum);
            Console.WriteLine("Произведение: {0}", sumDiag * linesum);
            Console.ReadLine();

        }

        static int[,] GenerateMatrixFunc(int a, int b)
        {
            int[,] matrix = new int[a, b];

            Random rnd = new Random();
            for (var i = 0; i < a; i++)
            {
                for (var j = 0; j < b; j++)
                {
                    matrix[i, j] = rnd.Next(-5, 5);
                }
            }

            return matrix;
        }

    }
}
