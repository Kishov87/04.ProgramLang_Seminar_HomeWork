// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console; 

Clear();

Write("Введите размер строк: ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов: ");
int n=int.Parse(ReadLine());

int[,] ar= FillArray(m, n);
WriteLine("Массив:");
PrintArray(ar);
WriteLine();
double[] average = GetAverage(ar);
PrintArray2(average);

double[] GetAverage(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
        {
        for (int j = 0; j < array.GetLength(0); j++)
        {
           result[i]+= array[j,i];
        }
        result[i]/=array.GetLength(0);
    }
    return result;
}

int[,] FillArray(int rows, int columns)
{
    int[,] array=new int[rows, columns];
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            array[i,j]= new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

void PrintArray2 (double[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Write($"{String.Join(", ", Math.Round(array2[i],1))}; ");
    }
}