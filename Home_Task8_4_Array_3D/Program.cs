// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void CreateArray(int[,,] matrix)   // метод создания трёхмерного  массива и заполнение его случайными числами
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[,,] array)   // метод вывода 3D массива на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}{(i,j,k)} ");
            }
            Console.WriteLine();
        }
    }
}

int dimention1 = 2; 
int dimention2 = 2;
int dimention3 = 2;
int[,,] myArray = new int[dimention1, dimention2, dimention3];
CreateArray(myArray);
PrintArray(myArray);
Console.WriteLine();