/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.*/

Console.Clear();
Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
if (number.Length != 5)
    Console.WriteLine("Введено не пятизначное число");
else
{
    if (number.Length % 2 == 0)
    {
        Console.WriteLine("Введённое число не является палиндромом");
    }
    else
    {
        if(number[0] == number [4] & number[1] == number[3])
        {
            Console.WriteLine("Введённое число является палиндром");
        }
        else
        {
            Console.WriteLine("Введённое число - не палиндром");
        }
    }
}

// Универсальное решение
/*Console.WriteLine("Введите слово или число:");
string value = Console.ReadLine();
int length = value.Length;

bool IsPalindrome()
{
    for (int i = 0; i < length/2; i++)
    while (value[i] == value[length-1])
    {
        return (true);    
    } 
    return (false);    
}
if (IsPalindrome())
{ 
    Console.WriteLine("Введное слово/число " + value + " является палиндромом");
}
else 
{
    Console.WriteLine("Введное слово/число " + value + " является палиндромом");
}*/