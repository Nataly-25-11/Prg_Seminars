﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
Console.Write ("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a2=(a%100-a%10)/10;
System.Console.WriteLine($"Вторая цифра: {a2}");

