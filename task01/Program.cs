﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string abc)
{
    Console.Write($"{abc} ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int b1 = GetNumber("Введите значение b1:");
int k1 = GetNumber("Введите значение k1:");
int b2 = GetNumber("Введите значение b2:");
int k2 = GetNumber("Введите значение k2:");

double x = (b2-b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения :{x}, {y}");