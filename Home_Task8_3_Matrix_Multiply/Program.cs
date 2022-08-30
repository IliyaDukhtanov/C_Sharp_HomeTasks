// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetMatrix(int row, int col, int min, int max)  // метод создания, заполнения случайными числами и возврата матрицы 2D 
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
} 

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)  // метод перемножения матриц 2D
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)]; 
    {
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(1); k++)
                {
                resultMatrix[i, j] += firstMatrix[i,k] * secondMatrix[k, j];
                }
            }
        }
        return resultMatrix;
    }
}

void PrintMatrix(int[,] matrix)   // метод вывода на экран матрицы 2D
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

int row = 3;
int col = 3;
int[,] firstMatrix = GetMatrix(row, col, 1, 10);
int[,] secondMatrix = GetMatrix(row, col, 1, 10);
int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
Console.Clear();
Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);
Console.WriteLine("");
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatrix);
Console.WriteLine("");
Console.WriteLine("Результирующая матрица");
PrintMatrix(resultMatrix);