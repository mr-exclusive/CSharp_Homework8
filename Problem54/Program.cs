//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:

//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void SortDescRowsInArray(int[,] arr)
{
    int temp, maxIndex;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            maxIndex = j;

            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, maxIndex])
                {
                    maxIndex = k;
                }
            }

            if (maxIndex != j)
            {
                temp = arr[i, j];
                arr[i, j] = arr[i, maxIndex];
                arr[i, maxIndex] = temp;
            }
        }
    }
}

Console.Clear();

Console.Write("Enter number of rows in array: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns in array: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, cols, 0, 9);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("After descending sort:");

SortDescRowsInArray(array);
PrintArray(array);