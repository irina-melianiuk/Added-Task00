//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortMatrix(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int n = 0; n < array.GetLength(1) - 1; n++)
      {
        if (array[i, n] < array[i, n + 1])
        {
          int temp = array[i, n + 1];
          array[i, n + 1] = array[i, n];
          array[i, n] = temp;
        }
      }
    }
  }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
Console.WriteLine();
SortMatrix(array2d);
PrintMatrix(array2d);