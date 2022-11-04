//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("m:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("n:");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
CreateArrayRandom(array);
PrintArray(array);
Console.WriteLine();
SortStr(array);
PrintArray(array);

void SortStr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
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

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[5, 4];
CreateArrayRandom(array);
PrintArray(array);
Console.WriteLine($"Наименьшая сумма элементов в строке {MinSumRow(array)}");

int MinSumRow(int[,] array)
{
    int minRow = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
        if (sum < minRow)
        {
            minRow = sum;
            minSum = i;
        }
        sum = 0;
    }
    return minSum + 1;
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


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

int[,] firstArray = new int[3, 3];
int[,] secondArray = new int[3, 3];
int[,] resultArray = new int[3, 3];

CreateArrayRandom(firstArray);
CreateArrayRandom(secondArray);
ProisFirstSecondArray(firstArray, secondArray, resultArray);

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();
Console.WriteLine("Произведение матриц:");
PrintArray(resultArray);

void ProisFirstSecondArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        for (int j = 0; j < firstArray.GetLength(1); j++)
        {
            resultArray[i, j] = firstArray[i, j] * secondArray[i, j];
        }
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

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

//using System.Drawing;

int[,,] array = new int[2, 2, 2];
int minNum = 1;
int maxNum = 10;
CreateArray(array, minNum, maxNum);
PrintArray(array);

void CreateArray(int[,,] array, int minNumber, int maxNumber)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = random.Next(minNumber, maxNumber + 1);

                    if (FindNumberInArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}

bool FindNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }

    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2})\t", i, j, k);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4

PrintArray(spiral(4));

int[,] spiral(int n)
{
    int[,] result = new int[n,n];
    int pos = 1;
    int count = n;
    int value = -n;
    int sum = -1;
    do
    {
        value = -1 * value / n;
        for (int i=0; i<count; i++)
        {
            sum +=value;
            result[sum / n, sum % n] = pos++;
        }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            result[sum / n, sum % n] = pos++;
        }


    }
    while (count > 0);
    return result;
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