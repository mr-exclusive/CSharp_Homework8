//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2

//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

int[,,] Get3DArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] arr = new int[m, n, p];
    Random random = new Random();
    int k = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            k = 0;

            while (k < p)
            {
                int num = random.Next(minValue, maxValue + 1);
                if (!FindElement(arr, num))
                {
                    arr[i, j, k] = num;
                    k++;
                }
            }
        }
    }

    return arr;
}

void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i}, {j}, {k})\t ");
            }
            Console.WriteLine();
        }
    }
}

bool FindElement(int[,,] arr, int element)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (arr[i, j, k] == element) return true;
            }
        }
    }

    return false;
}

Console.Clear();

Console.Write("Enter array 1st dimension: ");
int x = int.Parse(Console.ReadLine()!);

Console.Write("Enter array 2nd dimension: ");
int y = int.Parse(Console.ReadLine()!);

Console.Write("Enter array 3rd dimension: ");
int z = int.Parse(Console.ReadLine()!);

if (x * y * z <= 90) 
{
    int[,,] array = Get3DArray(x, y, z, 10, 99);
    Print3DArray(array);
}
else
{
    Console.WriteLine($"Not enough 2-digit positive integers to fill array of size {x}x{y}x{z} with unique numbers!");
}
