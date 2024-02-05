// Задача 59: Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        Clear();

        int[,] array = {
            { 3, 5, 2 },
            { 7, 1, 4 },
            { 9, 8, 6 }
        };

        WriteLine("Исходный массив:");
        PrintArray(array);

        int minRow = 0, minCol = 0;
        int min = array[0, 0];

        // Находим индексы наименьшего элемента
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Удаляем строку
        int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1)];
        for (int i = 0, newRow = 0; i < array.GetLength(0); i++)
        {
            if (i == minRow)
                continue;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[newRow, j] = array[i, j];
            }
            newRow++;
        }

        // Удаляем столбец
        int[,] finalArray = new int[newArray.GetLength(0), newArray.GetLength(1) - 1];
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            int newCol = 0;
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                if (j == minCol)
                    continue;

                finalArray[i, newCol] = newArray[i, j];
                newCol++;
            }
        }

        // Выводим результат
        WriteLine("Массив после удаления строки и столбца с наименьшим элементом:");
        PrintArray(finalArray);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Write(array[i, j] + " ");
            }
            WriteLine();
        }
    }
}