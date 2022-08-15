// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

class Program
{
static int[] CreateArray(int number) // создание массива
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}
static void PrintArray(int[] array)  // печать массива
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
static void Main(string[] args)
{
    Console.Clear();
    Console.WriteLine("Введите число элементов массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(length);
    PrintArray(array);
}
}
