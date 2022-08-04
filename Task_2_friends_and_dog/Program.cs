/*Задача 3. Задача с собакой и друзьями
Условие
Два друга движутся навстречу с заданной скоростью. Скорость первого — 1 м/с, второго —
2 м/с. У них есть собака, которая бегает со скоростью 5 м/с. Когда друзья начинают свой
путь, собака бежит от одного друга к другому, добегает, разворачивается и тут же бежит
обратно. Сколько раз собака перебежит от одного друга к другому, пока они не встретятся?
Введение в программирование | Лекция 1
Решить с конкретными числами
Решить в общем виде*/

Console.Write("Введите скорость первого друга, м/с: ");
int speed1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость второго друга, м/с: ");
int speed2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите скорость собаки, м/с: ");
int speedDog = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите расстояние между друзьями, м: ");
int dist = Convert.ToInt32(Console.ReadLine());
int time = 0;
int friend = 2; 
int count = 0;

while (dist > 5)
{
    if (friend > 1)
    {
        time = dist/(speed2 + speedDog);
        friend = 1;
    }
    else
    {
        time = dist/(speed1 + speedDog);
        friend = 2;
    }
    dist -= (speed1 + speed2)*time;
    count++;
}
Console.Write("Собака пробежит: ");
Console.WriteLine(count);
Console.WriteLine(" раз ");