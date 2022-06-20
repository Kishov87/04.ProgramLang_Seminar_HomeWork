// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console; 

Clear();

WriteLine("Введите координаты A:");

Write("Координаты X1: ");
int x1 = int.Parse(ReadLine());
Write("Координаты Y1: ");
int y1 = int.Parse(ReadLine());
Write("Координаты Z1: ");
int z1 = int.Parse(ReadLine());

WriteLine("Введите координаты B:");
Write("Координаты X2: ");
int x2 = int.Parse(ReadLine());
Write("Координаты Y2: ");
int y2 = int.Parse(ReadLine());
Write("Координаты Z2: ");
int z2 = int.Parse(ReadLine());
int answer = 0;

int sqrX=Convert.ToInt32(Math.Pow((x2-x1), 2));
int sqrY=Convert.ToInt32(Math.Pow((y2-y1), 2));
int sqrZ=Convert.ToInt32(Math.Pow((z2-z1), 2));

WriteLine($"Расстояние = {Math.Sqrt(sqrX+sqrY+sqrZ)}");