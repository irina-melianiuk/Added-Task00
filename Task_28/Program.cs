// Задача 28
//Напишите программу, которая принимает на вход число N  и выдает роизведение чисел от 1 до N.
// 4 -- 24
// 5 -- 120

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(1, 10);  
// Console.WriteLine($"Случайное число => {number}");

int result = Multiplication(number);
Console.WriteLine($"Результат умножения = {result}");

int Multiplication (int num) 
{
  int multi = 1;
  for (int i = 1; i <= num; i++)
  {
    checked
    {
      multi = multi * i;
    }
  
  }
  return multi;
}