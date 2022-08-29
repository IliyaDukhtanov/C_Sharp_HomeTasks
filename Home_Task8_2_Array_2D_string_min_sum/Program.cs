// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void CreateArray(int[,] matrix)   // метод создания двумерного массива с возможностью вывода на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix, int min, int max) // метод заполнения массива случайными числами в указанном пользователем диапазоне
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
}
int SumDigitsRows(int[,] matrix) // метод вычисления суммы элементов строки, сравнения сумм чисел и сохранения индекса строки
{
    int index = 1;
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result) 
        {
            result = sum; 
            index = i + 1;
        }
    }
    return index;    
}
Console.WriteLine("Введите число строк массива "); 
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива "); 
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент массива "); 
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальный массива "); 
int min = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array, max, min);
CreateArray(array);
Console.WriteLine();
int index = SumDigitsRows(array); 
Console.WriteLine("Наименьшая сумма элементов в строке " + index);
