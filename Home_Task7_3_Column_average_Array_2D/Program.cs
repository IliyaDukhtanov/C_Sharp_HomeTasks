// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void PrintArray(int[,] matrix)   // метод вывода двумерного массива
{
    Console.WriteLine("Исходный массив:");
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matrix) // метод заполнения массива случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}
void AverageArrayColumn(int[,] matrix)  // подсчёт среднего арифметического значений в столбцах массива и вывод результатов
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.WriteLine();
        double avg = sum / matrix.GetLength(0);
        Console.Write($"Среднее арифметическое значений массива в столбце {j + 1} равно {avg:F1} ");
    }
}
Console.Clear();
Console.WriteLine();
Console.WriteLine("Введите число строк массива "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива "); 
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m,n];
Console.WriteLine();
FillArray(array);
PrintArray(array);
AverageArrayColumn(array);
Console.WriteLine();