// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int RecursionSum(int m, int n)  //Рекурсивный метод суммирования чисел от M до N
{
    if (m > n) 
    {
        int temp = m;
        m = n; 
        n = temp;
    }   
    if (n == m) return n;
    else return n + RecursionSum(m, n-1);
}

int InputNumbers(string input)  //  метод для ввода данных пользователем
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

Console.Clear();
Console.WriteLine();
int m = InputNumbers("Введите первое число (M): ");
int n = InputNumbers("Введите второе число (N): ");
Console.WriteLine();
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {RecursionSum(m, n)}");
Console.WriteLine();
