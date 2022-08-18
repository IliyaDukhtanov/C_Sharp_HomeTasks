// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

class Programm 
{
static void Main(string[] args)
{
    Console.Clear();
    int[] array = new int[0]; // сначала создаём пустой массив
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
    static void PrintResult(int[] array)  // вычисление и печать результата
    {
    Console.WriteLine("Вывод массива");
    int posMax = 0;
    int posMin = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            if (array[i] > array[posMax]) posMax = i;
            else {}
            if (array[i] < array[posMin]) posMin = i;
            else {}
        }
        System.Console.WriteLine();
        Console.WriteLine("Разница между Max и Min элементом массива = " + (array[posMax] - array[posMin]));
        System.Console.WriteLine();
        //dif = array[posMax] - array[posMin];
    }
PrintResult(array);
}
}