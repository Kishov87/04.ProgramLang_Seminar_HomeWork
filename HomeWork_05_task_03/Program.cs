// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using System;
using static System.Console; 

Clear();

int[] array = GetRandomArray(5,0,100);
WriteLine($"[{String.Join(" ", array)}]");
WriteLine($"Разница между MAX и MIN элементом массива = {GeеDiffMaxMinIndex(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result=new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int GeеDiffMaxMinIndex(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else 
        {
            if (array[i] < min) min = array[i];
        }
    }
    return (max-min);
}