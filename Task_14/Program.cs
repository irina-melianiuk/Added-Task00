// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -- нет 
// 46 -- нет
// 161 -- да

Console.Write("Введите число 1 - ");
int number = Convert.ToInt32(Console.ReadLine());   

int result = Kratno(number);

if (result == 0)
  Console.Write($"да");
else
  Console.Write($"нет");

bool Kratno (int num)
{
int kratno = num%7 & num%23;

if (num%7) & (num%23);
   return kratno; 
}
