// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/////// Вариант решения с массивом и циклами FOR
Console.Clear();
Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int[] digit = new int[number.Length];
int sum = 0;
for (int i = 0; i < number.Length; i++) // создание массива из цифр введённого числа
{
    digit[i] = int.Parse(number[i].ToString());   // преобразование строкового представления числа в цифровое
}
for (int i = 0; i < number.Length; i++)  // подсчёт суммы цифр введённого числа
{
    sum = sum + digit[i];
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);


/////// Вариант решения с циклом WHILE и вычислениями
/*Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
int digit = number % 10;
number = number / 10;
sum = sum + digit;
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum);*/