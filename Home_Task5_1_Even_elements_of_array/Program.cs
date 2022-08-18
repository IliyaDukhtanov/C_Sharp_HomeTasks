// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

static int[] CreateArray(int number) // создание массива
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
static void PrintResult(int[] array)  // расчёт и вывод результатов
{
    Console.WriteLine("Вывод массива");
    int even = 0;
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] %2 == 0) even++;
        else odd++;
    }
    System.Console.WriteLine();
    Console.WriteLine("Количество четных чисел " + even + ", количество нечетных чисел " + odd);
    System.Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите число элементов массива:");
int length = Convert.ToInt32(Console.ReadLine());
PrintResult(CreateArray(length));