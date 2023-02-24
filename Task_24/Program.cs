// Задача 24.
// Напишите программу, которая принимаетна вход число (A) и выдает сумму чисел от 1 до A.
// 7 -- 28
// 4 -- 10
// 8 -- 36

Console.WriteLine("Введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");

int SumNumber (int num) // num = number
{
  int sum = 0;
  for (int i = 0; i <= num; i++)
  {
    sum = sum + i;
  }

  return sum;
}

