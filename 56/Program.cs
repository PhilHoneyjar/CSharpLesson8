// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
GetFillArray(array);
PrintArray(array);

int minSumRow = 0;
int sumRow = SumRow(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRow(array, i);
    if (sumRow > tempSumRow)
    {
        sumRow = tempSumRow;
        minSumRow = i;
    }
}

System.Console.WriteLine($"Smallest row is {minSumRow + 1}");

int SumRow(int[,] array, int i)
{
    int sumRow = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i, j];
    }
    return sumRow;
}

void GetFillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}