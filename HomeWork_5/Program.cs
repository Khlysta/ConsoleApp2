//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Длина массива:");
int size = int.Parse(Console.ReadLine());
int[] array = CreateArray(size);
GetArray(array);
Console.Write($"Количество четных чисел = {FindInArray(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 999);
    }
    return array;
}

int FindInArray(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

void GetArray(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i].ToString()}, ";
    }
    Console.WriteLine($"array: {result}");

}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Длина массива:");
int size = int.Parse(Console.ReadLine());
int[] array = CreateArray(size);
GetArray(array);
Console.Write($"Сумма элементов, стоящих на нечетных позициях = {SumCount(array)}");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 9);
    }
    return array;
}
void GetArray(int[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i].ToString()}, ";
    }
    Console.WriteLine($"array: {result}");

}

int SumCount(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Длина массива:");
int size = int.Parse(Console.ReadLine());
double[] array = CreateArray(size);
GetArray(array);
Console.Write($"Ркзница между макс и мин = {DifferenceMinMax(array)}");

double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1,9);
    }
    return array;
}
void GetArray(double[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i].ToString()}, ";
    }
    Console.WriteLine($"array: {result}");

}

double DifferenceMinMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }

    double difference = max - min;

    return difference;
}