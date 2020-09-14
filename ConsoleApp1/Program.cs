using Microsoft.VisualBasic;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Получение количества строк, столбцов двумерного массива, перебор;
            //int[,] mass = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            //int rows = mass.GetUpperBound(0) + 1;
            //int columns = mass.Length / rows;

            //for (int i = 0; i < rows; i++)
            //{
            //    for(int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{mass[i,j]} \t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Зубчатый массив, перебор
            //int[][] numbers = new int[3][];
            //numbers[0] = new int[] { 1, 2 };
            //numbers[1] = new int[] {1, 2, 3};
            //numbers[2] = new int[] { 1, 2, 3, 4, 5 };

            //foreach (int[] row in numbers)
            //{
            //    foreach (int number in row)
            //    {
            //        Console.Write($"{number} \t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write($"{numbers[i][j]} \t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Задачи с массивами

            #region Количество положительных чисел в массиве
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            //int count = 0;

            //foreach(int number in numbers)
            //    {
            //        if(number > 0)
            //        {
            //            count++;
            //        }
            //    }
            //Console.WriteLine(count);

            #endregion
            
            #region Инверсия массива
            //int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

            //int numbersLength = numbers.Length;
            //int numbersMiddle = numbersLength / 2;
            //int temporary;

            //for (int i = 0; i < numbersMiddle; i++)
            //{
            //    temporary = numbers[i];
            //    numbers[i] = numbers[numbersLength - i - 1];
            //    numbers[numbersLength - i - 1] = temporary;
            //}
            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} \t");
            //}
            #endregion

            #region Перебор трёхмерного массива
            //int[,,] numbers = {  { { 1, 2 },{ 3, 4 } },
            //                     { { 4, 5 }, { 6, 7 } },
            //                     { { 7, 8 }, { 9, 10 } },
            //                     { { 10, 11 }, { 12, 13 } } 
            //                   };

            //int x = numbers.GetUpperBound(0);
            //int y = numbers.GetUpperBound(1);
            //int z = numbers.GetUpperBound(2);

            //Console.Write("{");
            //for(int i = 0; i <= x; i++)
            //{
            //    Console.Write("{");
            //    for (int j = 0; j <= y; j++)
            //    {
            //        Console.Write("{");
            //        for (int k = 0; k <= z; k++)
            //        {
            //            Console.Write($"{numbers[i,j,k]}");
            //            if(k < z)
            //            {
            //                Console.Write(" , ");
            //            }
            //        }
            //        Console.Write("}");
            //        if (j < y)
            //        {
            //            Console.Write(", ");
            //        }
            //    }
            //    Console.Write("}");
            //    if (i < x)
            //    {
            //        Console.Write(" , ");
            //    }

            //}
            #endregion

            #region Программа сортировки массива

            ////Ввод чисел
            //int[] nums = new int[7];
            //Console.WriteLine("Введите семь чисел");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("{0}-е число: ", i + 1);
            //    nums[i] = Int32.Parse(Console.ReadLine());
            //}

            ////Сортировка

            //int temporary;
            //for (int i = 0; i < nums.Length -1; i++)
            //{
            //    for(int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            temporary = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temporary;
            //        }
            //    }
            //}

            ////Вывод значений

            //Console.WriteLine("Вывод отсортированного массива");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i] + "\t");
            //}

            #endregion
                
            #endregion


        }
    }
}
