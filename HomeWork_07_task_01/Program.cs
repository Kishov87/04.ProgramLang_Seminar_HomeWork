﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console; 

Clear();

Write("Введите размер строк: ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов: ");
int n=int.Parse(ReadLine());

double[,] myArray = GetRandomArray(m, n);
PrintArray(myArray);

double[,] GetRandomArray(int row, int column)
{
    double[,] result=new double[row, column];
    for(int i=0; i< result.GetLength(0);i++)
    {
        for(int j=0; j< result.GetLength(1);j++)
        {
            result[i,j]= new Random().Next(-10,10) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            Write($"{Math.Round(array[i,j],1)} ");
        }
        WriteLine();
    }
}