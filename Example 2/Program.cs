﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

//AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2


Console.Clear();

Console.WriteLine("Введите х1");
int x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите х2");
int x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt((x2 - x1)*(x2 - x1)  + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));

Console.WriteLine("Расстояние между точками: " + AB.ToString("N2"));


