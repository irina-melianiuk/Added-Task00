// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] NewArray(int num)
{
  int[] arr = new int[num];
  for (int i = 0; i < num; i++)
  {
    Console.WriteLine($"Введите {i+1} элемент массива: ");
    int element = Convert.ToInt32(Console.ReadLine());
    arr[i] = element;
  }
  return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int CheckArray (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] > 0) count++;
    }    
    return count;
}


Console.WriteLine("Введите количество элементов в массиве");
int number = Convert.ToInt32(Console.ReadLine()); 
int[] arr = NewArray(number);
Console.WriteLine($"Полученный массив из {number} элементов ");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"В массиве присутсвует {CheckArray (arr)} элементов больше нуля.");

