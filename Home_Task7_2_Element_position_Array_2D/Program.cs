// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void PrintArray(int[,] matrix)   // метод создания двумерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i , j]} ");
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
            matrix[i , j] = new Random().Next(1, 10);
        }
    }
}
Console.WriteLine("Введите число строк массива "); 
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива "); 
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m , n];
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите позицию искомого элемента массива "); 
int index = Convert.ToInt32(Console.ReadLine());
int row = index / 10;
int col = index % 10; 
if (row > m - 1 || col > n - 1) Console.WriteLine("Элемента на такой позиции в массиве нет");
else Console.WriteLine($"Искомый элемент равен {array[row , col]}");




