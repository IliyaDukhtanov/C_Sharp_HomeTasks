// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void CreateArray(int[,] matrix) // метод создания массива 2D и вывода на экран
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

void FillArray(int[,] matrix) // Метод заполнения массива 2D
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
}

void SortArrayStrings(int[,] matrix) // Метод сортировки значений в строках массива 2D и вывод результата на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxPos = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxPos]) maxPos = k;
            }   
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, maxPos];  
            matrix[i, maxPos] = temp;               
        Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];

FillArray(array);
CreateArray(array);
Console.WriteLine();
SortArrayStrings(array);