// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = int.Parse(readInput);
  return result;
}

int Exponentiation (int num1, int num2)
{
    int res = 1;
    for (int i = 0; i < num2; i++)
      {
        res *= num1;
      }
    return res;
}

bool CheckingNumber (int num2)
{
if (num2 < 0)
{
  Console.Write("Значение числа B должно быть положительным.");
  return false;
}
return true;
}

int number1 = Promt ("Введите число A -- ");
int number2 = Promt ("Введите число B -- ");
int exponentiation = Exponentiation(number1, number2);
if (CheckingNumber (number2))
{
Console.WriteLine($"Число {number1} в степени {number2} = {exponentiation}");
}