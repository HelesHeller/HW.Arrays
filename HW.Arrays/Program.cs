using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1: Відображення кількості парних, непарних та унікальних елементів масиву
            int[] numbers = { 1, 2, 3, 4, 5, 2, 6, 7, 8, 9, 1 };

            int evenCount = numbers.Count(n => n % 2 == 0);
            int oddCount = numbers.Count(n => n % 2 != 0);
            int uniqueCount = numbers.Distinct().Count();

            Console.WriteLine($"Кількість парних елементів: {evenCount}");
            Console.WriteLine($"Кількість непарних елементів: {oddCount}");
            Console.WriteLine($"Кількість унікальних елементів: {uniqueCount}");

            // Завдання 5: Знаходження мінімального і максимального значення у двовимірному масиві
            int[,] matrix = {
            {1, 5, 3},
            {8, 2, 9},
            {4, 7, 6}
        };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int min = matrix[0, 0];
            int max = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }

                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"Мінімальне значення: {min}");
            Console.WriteLine($"Максимальне значення: {max}");

            // Завдання 8: Підрахунок кількості голосних літер у реченні
            Console.Write("Введіть речення: ");
            string sentence = Console.ReadLine().ToLower();

            int vowelCount = 0;

            foreach (char c in sentence)
            {
                if ("aeiouаеіоуюяєї".Contains(c))
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"Кількість голосних літер у реченні: {vowelCount}");
        }
    }
}
