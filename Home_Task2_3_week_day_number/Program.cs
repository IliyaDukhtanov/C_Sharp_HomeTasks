/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным*/

// Вариант1
/*int[] week = new int[7]{1,2,3,4,5,6,7}; // задан массив номеров дней недели
Console.WriteLine("Введите цифру, обозначающую день недели:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < week[5])
{
    Console.WriteLine("Введённый день является рабочим");
}
else
{
    Console.WriteLine("Введённый день является выходным");
}*/


// Вариант 2
//static void Main(string[] args);
Dictionary<int, string> week = new Dictionary<int, string>()
{
    {1, "Понедельник, рабочий день"},
    {2, "Вторник, рабочий день"},
    {3, "Среда, рабочий день"},
    {4, "Четверг, рабочий день"},
    {5, "Пятница, рабочий день"},
    {6, "Суббота, выходной день"},
    {7, "Воскресенье, выходной день"},
};
Console.WriteLine("Введите цифру, обозначающую день недели:");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(week[day]);
