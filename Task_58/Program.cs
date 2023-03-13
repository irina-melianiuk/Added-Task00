// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix) //, int[,] multiplyMatrix)
{
  int[,] multiplyMatrix = new int [firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
  for (int i = 0; i < multiplyMatrix.GetLength(0); i++)
  {
    for (int j = 0; j <  multiplyMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k <  firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      multiplyMatrix[i,j] = sum;
    }
  }
  return multiplyMatrix;
}

int[,] firstArray2d = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(firstArray2d);
Console.WriteLine();
int[,] secondArray2d = CreateMatrixRndInt(3, 3, 1, 5);
PrintMatrix(secondArray2d);
Console.WriteLine();
int[,] multiplyArray2d = MultiplyMatrix(firstArray2d, secondArray2d);
PrintMatrix(multiplyArray2d);

