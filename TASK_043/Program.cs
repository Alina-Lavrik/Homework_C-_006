﻿/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем. 
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите значение для b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение для k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());


/*Приравневаем правые части данных равенств, потому что они обе равны y
k1 * x + b1 = k2 * x + b2 , выразим отсюда x: x =(b2-b1)/(k1-k2)
затем подставим полученое значение x в выражение для y : y = k1(b2 - b1)/(k1-k2) + b1*/


var x =(b2-b1)/(k1-k2);
var y = k1*(b2 - b1)/(k1-k2) + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"Точка пересечения двух прямых ({x} ; {y})");
