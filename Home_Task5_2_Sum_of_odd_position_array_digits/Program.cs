// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

static int[] CreateArray(int length) // создание массива случайных чисел с задаваемой пользователем длиной
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}
static void PrintResult(int[] array)  // расчёт и вывод результатов
{
    Console.WriteLine("Вывод массива");
    int sumEven = 0;
    int sumOdd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 == 0) sumEven = sumEven + array[i];
        else sumOdd = sumOdd + array[i];
    }   
    System.Console.WriteLine();
    Console.WriteLine("Сумма элементов массива на нечётных позициях равна " + sumOdd);
    Console.WriteLine("Сумма элементов массива на чётных позициях равна " + sumEven);
    System.Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите число элементов массива:");
int length = Convert.ToInt32(Console.ReadLine());
PrintResult(CreateArray(length));