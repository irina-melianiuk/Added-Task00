// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -- нет 
// 46 -- нет
// 161 -- да

Console.Write("Введите число 1 - ");
int number = Convert.ToInt32(Console.ReadLine());   

bool Result(int num)
{
  return (num % 7 == 0 && num % 23 == 0);
}


if (Result(number)) 
  Console.WriteLine($"да");
else
  Console.WriteLine($"нет");
