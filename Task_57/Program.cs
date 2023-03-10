// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
  int c = 0;
  int[] array = new int[matrix.Length];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      array[c] = matrix[i, j];
      c += 1;
    }
  }
  return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
void CountElemArray(int[] arr)
{
  int count = 1;
  int curentNumber = arr[0];
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] == curentNumber) count++;
    else
    {
      Console.WriteLine($" Число {curentNumber} встречается {count} раз.");
      curentNumber = arr[i];
      count = 1;
    }
  }
  Console.WriteLine($" Число {curentNumber} встречается {count} раз.");
}

int[,] matrix = CreateMatrixRndInt(3, 3, 1, 5);
int[]array = MatrixToArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
CountElemArray(array);

