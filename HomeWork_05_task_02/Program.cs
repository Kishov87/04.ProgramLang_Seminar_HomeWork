// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
using static System.Console; 

Clear();

int[] array = GetRandomArray(6,-100,100);
WriteLine($"[{String.Join(", ", array)}]");
WriteLine($"Сумма элементов стоящих на нечётных позициях массива = {GetSumOddIndex(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result=new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int GetSumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum+=i%2==1?array[i]:0;
    }
    return sum;
}