// Напишите программу, которая заполнит спирально массив 4 на 4.

System.Console.Write("Input matrix size (default 4): ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, rows];
int temp = 1;
int i = 0;
int j = 0;

while (temp <= rows * rows)
{
    array[i, j] = temp;
    if (i <= j + 1 && i + j < rows - 1) j++;
    else if (i < j && i + j >= rows - 1) i++;
    else if (i >= j && i + j > rows - 1) j--;
    else i--;
    temp++;
}
for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        System.Console.Write($"{array[x, y]}\t");
    }
    System.Console.WriteLine();
}