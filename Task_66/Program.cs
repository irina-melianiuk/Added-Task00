// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int number2 = int.Parse(Console.ReadLine());
 Console.Write($"Сумма натуральных элементов в промежутке от M до N равна {SumNumber(number1, number2)} ");

int SumNumber(int num1, int num2)
{
  if (num1 == 0) return (num2 * (num2 + 1)) / 2;           
  else if (num2 == 0) return (num1 * (num1 + 1)) / 2;       
  else if (num1 == num2) return num1;                      
  else if (num1 < num2) return num2 + SumNumber(num1, num2 - 1); 
  else return num2 + SumNumber(num1, num2 + 1);
}
