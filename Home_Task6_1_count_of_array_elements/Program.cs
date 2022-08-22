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
PrintResult(CreateArray(123)); // массив в 123 элементов
