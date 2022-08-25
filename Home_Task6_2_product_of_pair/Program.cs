// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

class Programm
{
    static int[] CreateArray(int length) // создание массива случайных чисел
    {
        int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
           array[i] = new Random().Next(1, 10);
        }
        return array;
    }

    static void PrintArray(int[] array)  // вывод исходного массива
    {
        Console.WriteLine("Вывод исходного массива"); // печать введённого массива
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        } 
    } 

    static void PrintResult(int[] array)
    {   
        Console.WriteLine(); 
        Console.WriteLine("Вывод результатов перемножения пар ");
        for (int i = 0; i < array.Length / 2; i++) // счётчик до середины массива и вычисление произведения 
        {
            int result = array[i] * array[array.Length - 1 - i];
            Console.Write(result + " ");
        }
        Console.WriteLine();
        if (array.Length % 2 != 0) Console.WriteLine($"Число {array[array.Length/2]} не имеет пары");

    }     
    static void Main(string[] args)
    {
        Console.Clear();
        int[] array = CreateArray(5);
        PrintArray(array);
        PrintResult(array);
    }
} 


// Вариант от препода с выводом всех результатов в массив

/*using System; 
Console.WriteLine("Введите элементы массива через пробел: "); 
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

int[] GetArrayFromString(string stringArray) // преобразование в числа
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries); // получаем стринговый массив Удаляет пробелы в частности
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]); // преобразование в int 
    }
    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 -i];
    }
    if (array.Length % 2 == 1) result[size - 1] = array[array.Length / 2];
    return result;
}*/