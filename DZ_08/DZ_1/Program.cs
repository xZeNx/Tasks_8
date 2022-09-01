// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.

int m = Numbers("Количество строк: ");
int n = Numbers("Количество столбцов: ");
int[,] matrix = new int[m, n];

FillArr(matrix);
PrintArr(matrix);
Order(matrix);
Console.WriteLine();
PrintArr(matrix);

void Order(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int min = j;

            for (int p = j + 1; p < matrix.GetLength(1); p++)
            {
                if (matrix[i, p] < matrix[i, min])
                {
                    min = p;
                }
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, min];
            matrix[i, min] = temp;
        }
    }
}

int Numbers(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArr(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
