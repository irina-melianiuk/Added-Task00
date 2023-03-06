// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -- 101101
// 3 -- 11
// 2 -- 10

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = Convert.ToInt32(readInput);
  return result;
}

int ConvertatoinNumber (int num)
{
  int res = 0;
  int count = 1;
  while (num > 0)
  {
    res = res +  num % 2 * count;
    num = num / 2;
    count *= 10;
  }
  return res;
}
int number = Promt ("Введите число ");
//int res = ConvertatoinNumber(number);
Console.WriteLine($"Число {number} в двоичной системе записи =  {ConvertatoinNumber(number)}");

