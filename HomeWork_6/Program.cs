//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] array = new int[100];  // до 100 чисел
int i = 0;

int[] CreateArray(int i)
{
    while (true)
    {
        string end = Console.ReadLine();
        if (end == "end") break;
        array[i] = int.Parse(end);
        ++i;
    };
    return array;
}

int Comp(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

Console.Write($"Количество положительных чисел: {Comp(CreateArray(i))}");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2, 2];
double[] СrossPoint = new double[2];
InputCoeff();
PrintCoord(coeff);

void InputCoeff()
{
    for (int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1} уравнения (y = k * x + b):\n");
        for (int j = 0; j < coeff.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"k: ");
            else Console.Write($"b: ");
            coeff[i, j] = int.Parse(Console.ReadLine());
        }
    }
}

double[] Raschet(double[,] coeff)
{
    СrossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    СrossPoint[1] = СrossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return СrossPoint;
}

void PrintCoord(double[,] coeff)
    {
        Raschet(coeff);
        Console.Write($"Точка пересечения 2-х прямых: ({СrossPoint[0]}; {СrossPoint[1]})");
    }

