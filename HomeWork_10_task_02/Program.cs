// Задача 61: Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;
class Program
{
    static void Main()
    {
        int numRows = 6; // Количество строк треугольника Паскаля

        for (int i = 0; i < numRows; i++)
        {
            // Выводим пробелы для выравнивания треугольника
           Write(new string(' ', numRows - i));

            int number = 1;
            for (int j = 0; j <= i; j++)
            {
                Write(number + " ");
                number = number * (i - j) / (j + 1);
            }

            WriteLine();
        }
    }
}