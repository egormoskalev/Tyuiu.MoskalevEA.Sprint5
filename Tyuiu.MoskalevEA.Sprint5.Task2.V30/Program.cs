using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MoskalevEA.Sprint5.Task2.V30.Lib;

namespace Tyuiu.MoskalevEA.Sprint5.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrx = new int[3, 3] { { 3, -1, -3 }, { -2, -5, 0 }, { -8, -7, 2 } };
            int rows = matrx.GetLength(0);
            int columns = matrx.GetLength(1);

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            string res = ds.SaveToFileTextData(matrx);
            Console.Write("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}