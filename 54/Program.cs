// Задайте двумерный массив
// Напишите программу, которая упорядочит по убыванию элементы каждой строки 

Console.Clear();

System.Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

GetFillArray(array);
PrintArray(array);

System.Console.WriteLine($"Max to min elements in rows: ");
MaxToMinRowElements(array);
PrintArray(array);

void MaxToMinRowElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
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