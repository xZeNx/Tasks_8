// Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

int m = Numbers("Введите число строк 1-й: ");
int n = Numbers("Введите число строк 2-й и столбцов 1-й матрицы: ");
int p = Numbers("Введите число столбцов 2-й матрицы: ");
int range = Numbers("Введите диапазон чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая:");
WriteArray(firstMartrix);

int[,] secMatrix = new int[n, p];
CreateArray(secMatrix);
Console.WriteLine($"\nВторая:");
WriteArray(secMatrix);

int[,] resultMatrix = new int[m,p];

Matrix(firstMartrix, secMatrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй:");
WriteArray(resultMatrix);

void Matrix(int[,] firstMatrix, int[,] secMatrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
