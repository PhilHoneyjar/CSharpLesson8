// Задайте две матрицы
// Напишите программу, которая будет находить произведение двух матриц

Console.Clear();

int[,] SizeMatrix()
{
    System.Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    return GetFillArray(new int [rows, columns]);
}

int[,] GetFillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Эти матрицы нельзя перемножить");
        return matrix1;
    }
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int[,] MatrixArray1 = SizeMatrix();
PrintArray(MatrixArray1);
int[,] MatrixArray2 = SizeMatrix();
PrintArray(MatrixArray2);

System.Console.WriteLine("Result Matrix: ");
int[,] Matrix = MultiplyMatrix(MatrixArray1, MatrixArray2);
PrintArray(Matrix);