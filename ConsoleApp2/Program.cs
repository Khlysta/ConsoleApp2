//

int[] CreateArray(int size, int minValue, int MaxValue)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, MaxValue);
    }
    return array;
}

int GetSumPositiveElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum = sum + array[i];
    }
    return sum;
}

int GetSumNegativeElementsFromArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum = sum + array[i];
    }
    return sum;
}

string GetArray(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]}, ";
    }
    return sum;
}

int[] array = CreateArray(12, -9, 10);

System.Console.WriteLine(GetArray(array));
System.Console.WriteLine("Сумма положительных элементов равна = " + GetSumPositiveElementsFromArray(array));
System.Console.WriteLine("Сумма отрицательных элементов равна = " + GetSumNegativeElementsFromArray(array));

//Массив делает отрицательным

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

int[] GetReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = -array[i];
    }

    return reversedArray;
}

string ArrayToString(int[] array)
{
    string result = "[";

    foreach (int item in array)
    {
        result += $"{item}, ";
    }

    result.Trim(',');
    result += "]";

    return result;
}

int[] array = CreateArray(10, -10, 10);

Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(GetReverseArray(array)));

//Находит заданное число в массиве

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

int[] GetReverseArray(int[] array)
{
    int[] reversedArray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        reversedArray[i] = -array[i];
    }

    return reversedArray;
}

string ArrayToString(int[] array)
{
    string result = "[";

    foreach (int item in array)
    {
        result += $"{item}, ";
    }

    result += "]";

    return result;
}

bool FindNumber(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return true;
    }

    return false;
}

int[] array = CreateArray(20, -5, 5);

int findNumber = int.Parse(Console.ReadLine());


Console.WriteLine(ArrayToString(array));
Console.WriteLine(ArrayToString(GetReverseArray(array)));
Console.WriteLine(FindNumber(array, findNumber));


//____________________-смотри скрины
int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}
int Qelements(int[] array)
{
    int counter = 0;

    foreach (int element in array)
    {
        if (element > 9 & element < 99) counter++;
    }
    return counter;
}
string GetArray1(int[] array)
{
    string sum = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + $"{array[i]}, ";
    }

    return sum;
}
int[] array = CreateArray(123, -150, 150);
System.Console.WriteLine(GetArray1(array));
System.Console.WriteLine(Qelements(array));

int[] ProzElem(int[] array)

{
    int[] arrayP = new int[array.Length / 2 + 1];
    int i;
    for (i = 0; i < array.Length / 2; i++)
    {
        arrayP[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0) arrayP[arrayP.Length - 1] = array[i];

    return arrayP;
}
array = CreateArray(5, 0, 10);
//System.Console. смотри скрины



///////////////// задайте двуменрый массив длиной м и н
/// 
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());


int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }

}
PrintArray(GetArray(m, n));





/////////////////////////
///
int[,] array = new int[4, 5];



string ArrayToString(int[,] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += $"{array[i, j]} ";
        }

        result += Environment.NewLine;
    }

    return result;
}

//////////
/// Задайте двумерный массив , каждый элемент находится по ормуле м + н
Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());


int[,] GetArray(int m, int n)

{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

string PrintArray(int[,] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += $"{array[i, j]} ";
        }
        result += Environment.NewLine;
    }
    return result;
}
Console.WriteLine(PrintArray(GetArray(m, n)));


// Меняет строку с толбцом в двумерке
int[,] UpdateArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

    if (array.GetLength(1) != array.GetLength(0))
    {
        throw new ArgumentException("Thiw array can't be reversed");
    }

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int[] column = CopyColumn(array, i);

        AddRowToArray(array, newArray, column, i);
    }



    return newArray;
}

int[] CopyColumn(int[,] array, int columnNumber)
{
    int[] coulumn = new int[array.GetLength(0)];

    for (int i = 0; i < coulumn.Length; i++)
    {
        coulumn[i] = array[columnNumber, i];
    }

    return coulumn;
}

void AddRowToArray(int[,] originArray, int[,] copiedArray, int[] row, int rowNumber)
{
    for (int i = 0; i < originArray.GetLength(0); i++)
    {
        copiedArray[i, rowNumber] = row[i];
    }
}

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 20);
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = CreateArray(5, 5);
PrintArray(array);

Console.WriteLine();

int[,] newArray = UpdateArray(array);
PrintArray(newArray);
