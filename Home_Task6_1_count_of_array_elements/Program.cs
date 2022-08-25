// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

static int[] CreateArray(int length) // создание массива случайных чисел
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return array;
}

static void PrintResult(int[] array)  // расчёт и вывод результатов
{
    Console.WriteLine("Вывод массива");
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (array[i] >= 10 & array[i] <= 99) count++;
    } 
    Console.WriteLine();
    Console.WriteLine("Количество элементов массива от 10 до 99 равно " + count); 
}

Console.Clear();
PrintResult(CreateArray(123)); // массив из 123 элементов


// Вариант препода
/*using System; 
int[] startArray = GetArray(123, 0, 1000); 
Console.WriteLine($"Количество элементов в отрезке [10;99]) = {GetCountElements(startArray, 10, 99)}");

int[] GetArray(int size, int minValue, int maxValue) // создание массива по входным данным
{
    int[] res = new int[size]; 
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item >= leftRange && item <= rigthRange) count++;
    }
    return count;
}
*/