// Задача 26
// Напишите программ, которая принимает на вход число и выдает количество цифр в числе.
// 456 --3
// 78 --2
// 89126 -- 5

int number = new Random().Next();  
 Console.WriteLine($"Случайное число => {number}");

int result = Count(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");


int Count(int num)
{ 
  int count = 0;
  while (num > 0)
    {
      if (num % 10 > 0)
      {
        num = num / 10;
        count = count + 1; 
      }
    }
  return (count);
}


