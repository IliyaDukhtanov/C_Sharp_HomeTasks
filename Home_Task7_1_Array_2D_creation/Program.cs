// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void CreateArray(double[,] matrix)  // Создание двумерного массива и вывод его
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
void FillArray(double[,] matrix)  //  Заполнение массива случайными вещественными числами от 1 до 10
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * 10;
        }
    }
}

Console.WriteLine("Введите число строк массива "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива "); 
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];
//CreateArray(array);
//FillArray(array);
Console.WriteLine();
FillArray(array);
CreateArray(array);

