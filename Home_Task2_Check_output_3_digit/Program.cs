/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.Clear();
Console.WriteLine("Введите число:");
string number = Convert.ToString(Console.ReadLine());
if (number.Length > 2)
{
    Console.WriteLine("Третья цифра введённого числа: " + number[2]);
}
else
{
    Console.WriteLine("У введённого числа третьей цифры нет");
}