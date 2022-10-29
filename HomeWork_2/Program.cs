//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Task10. Enter numbers:");
int n = int.Parse(Console.ReadLine());

if (n >= 100 && n <= 999)

{
    int result = (n / 10) % 10;
    Console.WriteLine($"The Second number is {result}");
}
else
{
    Console.WriteLine("Error");
}

//*******************************

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Task13. Enter numbers:");
int n = int.Parse(Console.ReadLine());

if (n < 100)
{
    Console.WriteLine("Error");
}
else
{
    int coef = 10;
    while (true)
    {

        int result = n / coef;
        if (result >= 100 && result <= 999)
        {
            break;
        }
        else
        {
            if (result >= 10 && result <= 99)
            {
                coef = 1;
            }
            else
            {
                coef *= 10;
            }

        }

    }
    Console.WriteLine($"The 3 number is {(n / coef) % 10}");
}

// 2-ое решение
Console.WriteLine("Task13. Enter numbers:");
int m = int.Parse(Console.ReadLine());

if (m > 99)
{
    Console.WriteLine(m.ToString()[2]);
}
else
{
    Console.WriteLine("no 3 number!");
}

//********************************
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

Console.WriteLine("Task15. Enter numbers:");
int n = int.Parse(Console.ReadLine());

if (n > 0 && n <= 7)
{
    switch (n)
    {
        case 6:
        case 7:
            Console.WriteLine("is weekend");
            break;
       default:
            Console.WriteLine("is not weekend");
            break ;

    }
}
else
{
    Console.WriteLine("Error");
}

