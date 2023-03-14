// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns]; // 0 , 1
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++) // rows
  {
    for (int j = 0; j < matrix.GetLength(1); j++) // columns
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, ");
      else Console.Write($"{matrix[i, j],3}");
    }
    Console.WriteLine("|");
  }
}

int LineAmount(int[,] matrix, int i)
{
  int sum = matrix[i,0];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sum += matrix[i, j];
  }
  return sum;
}
int NumberLineAmount(int[,] matrix)
{
  int lineNumber = 0;
  int sumLine = LineAmount(matrix,0);
  for (int i = 1; i < matrix.GetLength(0); i++)
  {
    int tempSumLine = LineAmount(matrix,i);
    if (sumLine > tempSumLine)
    {
      sumLine = tempSumLine;
      lineNumber = i;
    }
  }
  return lineNumber;
}

int[,] array2d = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(array2d);
Console.WriteLine();

int numberLineAmount = NumberLineAmount(array2d);
Console.Write($"Строка с наименьшей суммой элементов {numberLineAmount + 1}. ");
