// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат:
// 1-строка

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
int[] rowSums = GetRowsSum(ar);
GetRowsSum(ar);
WriteLine();
WriteLine($"{MinSum(rowSums)} - строка с наименьшей суммой элементов");

int[] GetRowsSum(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        result[i] = sum;
    }
    return result;
}

int MinSum (int[] array)
{
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < array[minIndex])  
        minIndex = i; 
    }
    return minIndex+1;
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