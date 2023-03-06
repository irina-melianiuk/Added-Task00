// Задача 44: Не используя рекурсию, выведите первые N  чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// 5 -- 0 1 1 2 3
// 3 -- 0 1 1 
// 7 -- 0 1 1 2 3 5 8

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int[] CreateArrayInt (int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 2] + arr[i - 1];
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
       Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
}


int number = Promt("Введите число: ");
int[] array = CreateArrayInt(number);
PrintArray(array);