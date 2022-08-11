// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max;
if (b > a)
{
    max = b;
}
else max = a;
if (c > max)
{
    max = c;
}
else 
{
}
Console.Write("Наибольшее из введённый чисел: ");
Console.WriteLine(max);