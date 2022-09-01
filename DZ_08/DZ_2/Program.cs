 // Задайте прямоугольный двумерный массив. Напишите программу, 
 // которая будет находить строку с наименьшей суммой элементов.

int a = Numbers("Введите A: ");
int b = Numbers("Введите B: ");
int range = Numbers("Диапазон: от 1 до ");

int[,] array = new int[a, b];
CreateArr(array);
WriteArr(array);

int minSum = 0;
int sumLine = SumLine(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLine(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - С наименьшей суммой ({sumLine}) элемента ");


int SumLine(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int Numbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArr (int[,] array)
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

