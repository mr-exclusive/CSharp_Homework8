//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:

//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07


int[,] CreateSpiralArray(int n)
{
    int[,] arr = new int[n, n];
    int i = 0;
    int j = 0;
    int temp = 1;

    while (temp <= arr.Length)
    {
        arr[i, j] = temp;
        temp++;

        if (i <= j + 1 && j + i < arr.GetLength(0) - 1) j++;
        else if (i < j && i + j >= arr.GetLength(0) - 1) i++;
        else if (i >= j && i + j > arr.GetLength(0) - 1) j--;
        else i--;
    }

    return arr;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j].ToString().PadLeft(2, '0')}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.Write("Enter number of rows/columns for square array: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = CreateSpiralArray(n);
PrintArray(array);