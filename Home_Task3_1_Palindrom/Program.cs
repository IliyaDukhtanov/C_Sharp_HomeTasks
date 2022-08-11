/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
if (number.Length != 5)
    Console.WriteLine("Введено не пятизначное число");
else
{
    if (number.Length % 2 == 0)
    {
        Console.WriteLine("Введённое число - не палиндром");
    }
    else
    {
        if(number[0] == number [4] & number[1] == number[3])
        {
            Console.WriteLine("Введённое число - палиндром");
        }
        else
        {
            Console.WriteLine("Введённое число - не палиндром");
        }
    }
}