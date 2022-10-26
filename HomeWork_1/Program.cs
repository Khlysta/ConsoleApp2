//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Task2. Enter numbers:");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

if (n > m)
{
    Console.WriteLine($"max = {n}");
}
else
{
    Console.WriteLine($"max = {m}");
}

//******************************

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Task4. Enter numbers:");
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (n > m) Console.WriteLine($"max = {n}");
else if (m > b) Console.WriteLine($"max = {m}");
else Console.WriteLine($"max = {b}");

//***********************************

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

Console.WriteLine("Task6. Enter numbers:");
int n = int.Parse(Console.ReadLine());
int i = n % 2;
if (i == 0) Console.WriteLine($"yes. number {n} - even");
else Console.WriteLine($"no. number {n} - uneven");

//***********************************

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("task8. enter numbers:");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    for (int i = 1; i <= N; i++)
    {
        if (i % 2 == 0) Console.WriteLine(i);
    }
}
else if (N < 0)
{
    for (int i = 1; i >= N; i--)
    {
        if (i % 2 == 0 && i != 0) Console.WriteLine(i);
    }
}


