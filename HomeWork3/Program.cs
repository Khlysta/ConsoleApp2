//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Task19. Enter numbers:");
int n = int.Parse(Console.ReadLine());

int m = n;
int i = 0;

if (n >= 10000 && n <= 99999)
{
    while (n >= 1000)
    {

        int ResultLast = n % 10;
        int ResultFirst = m / 10000;
        if (ResultFirst == ResultLast)
        {
            i++;
            n = n / 10;
            m = (m % 10000) * 10;

        }
        else
        {
            break;
        }


    }
    if (i == 2) Console.WriteLine("yes");
    else Console.WriteLine("no");
}
else
{ Console.WriteLine("error"); }

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите X точки А: ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите Y точки А: ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите Z точки А: ");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите X точки B: ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите Y точки B: ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите Z точки B: ");
int zB = int.Parse(Console.ReadLine());
double result = Math.Sqrt(((xB - xA) * (xB - xA)) + ((yB - yA) * (yB - yA)) + ((zB - zA) * (zB - zA)));
Console.WriteLine(result);

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine(" Enter numbers:");
int n = int.Parse(Console.ReadLine());

int count = 1;

while (count < n)
{
    Console.WriteLine(count * count * count + ", ");
    count++;
}
Console.WriteLine(count * count * count + ".");