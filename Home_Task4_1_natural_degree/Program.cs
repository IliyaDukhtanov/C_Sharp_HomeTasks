// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
int res = 1;
for (int i = 0; i < b; i++) // счетчик i может быть от 0 до < b, или от 1 до равно b
{
    res *=  a; // краткая запись умножения на себя
}
Console.WriteLine("Число " + a + " в степени " + b + " = " + res);
