// ** Задача 54.** Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Результат:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
SortArray(ar);
WriteLine();
PrintArray(ar);

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int n = j+1; n < array.GetLength(1); n++)
            {
                if (array[i,n] > array[i,max])
                max = n; 
            }
            int tempInt = array[i,j];
            array[i,j] = array[i,max];
            array[i,max] = tempInt;
        }
    }
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