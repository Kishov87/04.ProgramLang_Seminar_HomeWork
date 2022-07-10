// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9
// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0
// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using System;
using static System.Console; 

Clear();

Write("Введите размер строк: ");
int m=int.Parse(ReadLine());
Write("Введите число столбцов: ");
int n=int.Parse(ReadLine());

int[,] ar= FillArray(m, n);
WriteLine("Массив A:");
PrintArray(ar);
WriteLine();
int[,] ar2= FillArray(m, n);
WriteLine("Массив B:");
PrintArray(ar);
WriteLine();
WriteLine("Массив итоговый:");
int[,] resultMatrix = new int[m,n];

MultiplyMatrix(ar, ar2, resultMatrix);
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum+= firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
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