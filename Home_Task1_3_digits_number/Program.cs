﻿/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. */

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int second = (number % 100)/10;
Console.WriteLine("Вторая цифра введённого трехзначного числа: " + second);