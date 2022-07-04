// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console; 

Clear();

int m= 3;
int n= 4;

int[,] ar= FillArray(m, n);
WriteLine("Массив:");
PrintArray(ar);
WriteLine();

Write("Введите номер строки для поиска числа: ");
int P1=int.Parse(ReadLine());
Write("Введите номер столбца для поиска числа: ");
int P2=int.Parse(ReadLine());

WriteLine((P1-1<0 || P1-1 > ar.GetLength(0) - 1 || P2-1 < 0 || P2-1 > ar.GetLength(1) - 1)
?$"Заданный элемент не существует в массиве"
:$"Значение заданного элемента массива =  {ar[P1-1, P2-1]}");

int[,] FillArray(int rows, int columns)
{
    int[,] array=new int[rows, columns];
    for(int i=0; i< array.GetLength(0);i++)
    {
        for(int j=0; j< array.GetLength(1);j++)
        {
            array[i,j]= new Random().Next(1,100);
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