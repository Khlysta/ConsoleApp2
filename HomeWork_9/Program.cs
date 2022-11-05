
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.


Console.Write("введите N:");
int N = int.Parse(Console.ReadLine());
PrintResultNumbers(N);


void PrintResultNumbers(int n, int count = 1)
{
    if (count <= n)
    {
        PrintResultNumbers(n, count + 1);
        Console.Write(count + " ");
    }

}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("введите M:");
int M = int.Parse(Console.ReadLine());

Console.Write("введите N:");
int N = int.Parse(Console.ReadLine());

PrintSum(M, N);

void PrintSum(int M, int N)
{
    Console.Write(Sum(M - 1, N));
}

int Sum(int M, int N)
{
    int result = M;
    if (M != N)
    {
        M++;
        result = M + Sum(M, N);

    }
    else return 0;
    return result;

}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("введите M:");
int m = int.Parse(Console.ReadLine());

Console.Write("введите N:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 & n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else if (m > 0 & n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }

    return 0;
}