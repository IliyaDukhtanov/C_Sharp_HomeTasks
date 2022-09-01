// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

int AkkermanFunc(int m, int n)   // метод вычисления функции Аккермана
{
    if (m == 0)         return n + 1;
    else if (n == 0)    return AkkermanFunc(m - 1, 1);
    else                return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

int InputNumbers(string input)  //  метод для ввода данных для вычисления пользователем
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine());
  return output;
}

Console.Clear();
Console.WriteLine();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
//int func = AkkermanFunc(m, n);
Console.WriteLine();
Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равно {AkkermanFunc(m, n)}");
Console.WriteLine();

