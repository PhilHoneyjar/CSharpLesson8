// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

Console.Clear();

System.Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] array = GetFillArray(new int[] {x, y, z});
PrintArray(array);

int[,,] GetFillArray(int[] size)
{
    int[,,] baseArray = new int[x, y, z];
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        for (int j = 0; j < baseArray.GetLength(1); j++)
        {
            int k = 0;
            while (k < baseArray.GetLength(2))
            {
                var rnd = new Random().Next(10, 100);
                if (!FindElement(rnd, baseArray))
                {
                    baseArray[i, j, k] = rnd;
                    k++;
                }
            }
        }
    }
    return baseArray;
}

bool FindElement(int element, int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}