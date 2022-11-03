//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

Console.WriteLine("m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n:");
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];
CreateArrayRandom(array);
PrintArray(array);

void CreateArrayRandom(double[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-10, 10) + random.NextDouble();
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Номер столбца: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[5, 5];
CreateArrayRandom(array);
PrintArray(array);

if ((m < 5) & (n < 5)) Console.WriteLine($"Число: {array[m, n]}");
else Console.WriteLine("Нет такого числа");


void CreateArrayRandom(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;

Console.WriteLine("m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n:");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
CreateArrayRandom(array);
PrintArray(array);
PrintMiddleColumn(array);

void PrintMiddleColumn(int[,] array)
{

    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result = sum / array.GetLength(0);
        Console.Write($"Средняя сумма столбца {j + 1} = {result}" + "; \n");
    }
}

void CreateArrayRandom(int[,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }

        Console.WriteLine();
    }
}