//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = random.Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int FindRowWithMinSumElements(int[,] arr)
{
    int rowIndex = -1;
    int minSum = 0;
    int tempSum = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        tempSum = 0;

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempSum += arr[i, j];
        }

        if (tempSum < minSum || i == 0)
        {
            minSum = tempSum;
            rowIndex = i;
        }
    }

    return rowIndex;
}

Console.Clear();

Console.Write("Enter number of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in array: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 9);
PrintArray(array);

Console.WriteLine();

int rowMinSum = FindRowWithMinSumElements(array);
if (rowMinSum > -1)
{
    Console.WriteLine("Minimal sum of elements in row: " + (rowMinSum+1));
}
else
{
    Console.WriteLine("Incorrect array size!");
}