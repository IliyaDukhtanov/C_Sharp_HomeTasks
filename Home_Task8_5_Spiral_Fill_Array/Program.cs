// Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintArray(int[,] matrix)   // метод вывода на экран матрицы 2D
{
    const int cellWidth = 3;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],cellWidth}");
        }
        Console.WriteLine();
    }
}
int[,] SpiralFillArray(int[,] matrix) 
{   
    int value = 1;
    int i = 0;
    int j = 0;
    while (value <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = value;
        value++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;   
}

int n = 4;
int[,] matrix = new int[n, n];
Console.Clear();
Console.WriteLine($"Заполниние массива спирально:");
Console.WriteLine();
SpiralFillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
