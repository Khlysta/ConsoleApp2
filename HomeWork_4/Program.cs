//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Число:");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Степень:");
int B = int.Parse(Console.ReadLine());
VStepen(A, B);

void VStepen(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Число:");
int n = int.Parse(Console.ReadLine());
int sum = SumNumbers(n, NumberLenght(n));
Console.WriteLine($" Сумма цифр числа {n}: {sum}");


int NumberLenght(int n)
{
    int i = 0;
    while (n > 0)
    {
        n /= 10;
        i++;
    }
    return i;
}


int SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
}

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Длина массива:");
int lenghtArray = int.Parse(Console.ReadLine());


int[] CreateArray(int lenghtArray)
{
    int[] randomArray = new int[lenghtArray];
    Random random = new Random();
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = random.Next(1, 45);
        
    }
    return randomArray;
}

String GetArray(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i].ToString()}, ";
    }
    return result;

}

Console.WriteLine(GetArray(CreateArray(lenghtArray)));