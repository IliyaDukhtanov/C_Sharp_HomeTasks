/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве*/

Console.WriteLine("Введите координату X для точки A:");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки A:");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки A:");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X для точки B:");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y для точки B:");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z для точки B:");
int zb = Convert.ToInt32(Console.ReadLine());

//double s = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za)); 
double s = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine("Расстояние между точками A и B = " + s);