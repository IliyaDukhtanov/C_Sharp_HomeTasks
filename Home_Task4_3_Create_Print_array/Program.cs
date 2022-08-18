// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

class Program
{
/*static int[] CreateArray(int number) // создание массива
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}*/
static void PrintArray(int[] array)  // печать массива
{
    Console.WriteLine("Вывод массива");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
/*static void Main(string[] args)
{
    Console.Clear();
    Console.WriteLine("Введите число элементов массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(length);
    PrintArray(array);
}
}*/

static void Main(string[] args)
{
    int[] array = new int[0]; // сначала пустой массив
    while (true)
    {
        Console.WriteLine("Введите значение массива:"); ///// Создание массива произвольной длины в ручную.
        string meaning = Console.ReadLine();
        if(meaning != "end")
        {
            int number = Convert.ToInt32(meaning);
            int[] newArray = array;
            array = new int[array.Length +1];
            for (int i = 0; i < newArray.Length; i++)
            {
                array[i] = newArray[i];
            }
            array[array.Length-1] = number;
        }
        else
        {
            break; // конец программы ввода массива в ручную
        }
    }  
    PrintArray(array);
 }
 }
