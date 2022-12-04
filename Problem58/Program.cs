//Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.

//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3

//Результирующая матрица будет:
//18 20
//15 18

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

int[,] FindProductOfTwoMatrices(int[,] arr1, int[,] arr2)
{
    int[,] resultArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                resultArr[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }

    return resultArr;
}

Console.Clear();

Console.Write("Enter number of rows for 1st matrix: ");
int rows1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns for 1st matrix: ");
int cols1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns for 2nd matrix: ");
int cols2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Matrix 1");
int[,] array1 = GetArray(rows1, cols1, 0, 9);
//int[,] array1 = { { 2, 4 }, { 3, 2 } };
PrintArray(array1);

Console.WriteLine("Matrix 2");
int[,] array2 = GetArray(cols1, cols2, 0, 9);
//int[,] array2 = { { 3, 4 }, { 3, 3 } };
PrintArray(array2);

Console.WriteLine();
Console.WriteLine("Product of two matrices");
int[,] resultArr = FindProductOfTwoMatrices(array1, array2);
PrintArray(resultArr);