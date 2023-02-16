// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадртом другого.
// 5, 25 -- да
// -4,16 -- да
// 25,5 -- да
//8,9 -- нет

Console.Write("Введите число 1 - ");
int number1 = Convert.ToInt32(Console.ReadLine());   
Console.Write("Введите число 2 - ");
int number2 = Convert.ToInt32(Console.ReadLine()); 

bool Result(int num1, int num2)
{
 int a = num1*num1;
 int b = num2*num2;
  return (a == num2 | b == num1);
}

if (Result(number1,number2)) 
  Console.WriteLine($"да");
else
  Console.WriteLine($"нет");
