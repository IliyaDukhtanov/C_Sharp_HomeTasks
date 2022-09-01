﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

static int RecursionOutputNumbers(int m, int n) // рекурсивный метод вывода натуральных чисел от M до N по возрастанию
{
   if (m > n) 
    {
        int temp = m;
        m = n; 
        n = temp;
    }    
    Console.Write(m + " ");
    if (n == m + 1) return n;
    return RecursionOutputNumbers(m + 1, n);
}
//RecursionOutputNumbers(2, 11);

int InputNumbers(string input)  //  метод для ввода данных пользователем
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Console.Clear();
Console.WriteLine();
int m = InputNumbers("Введите первое число (M): ");
int n = InputNumbers("Введите второе число (N): ");
Console.WriteLine();
Console.WriteLine($"Все натуральные числа в диапазоне от {m} до {n}:");
Console.WriteLine(RecursionOutputNumbers(m,n));
Console.WriteLine();





/*int WriteNumbers(int a, int b)
{
    Console.Write(a + " ");
    if (a == b) return b;
    return WriteNumbers(a + 1,b);
}
WriteNumbers(3, 10); */






//int Fib(int n)
//{
//    Console.Write(n + " ");
//    if (n == 0 || n ==1) return n;
//    return n = Fib(n-1) + Fib(n-2);
//}
//Fib(10);


