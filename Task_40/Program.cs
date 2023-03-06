// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона стреугольника меньше суммы двух других сторон.

int Promt(string message)
{
  Console.Write(message);
  string readInput = Console.ReadLine();
  int result = Convert.ToInt32(readInput);
  return result;
}

bool TriangleExist(int num1, int num2, int num3)
{
  if ((num1 + num2 >= num3) && (num2 + num3 >= num1) && (num3 + num1 >= num2))
  {
    return true;
  }
  else 
  {
    return false;
  }
}

int number1 = Promt("Введите число 1 - ");
int number2 = Promt("Введите число 2 - ");
int number3 = Promt("Введите число 3 - ");

  if (TriangleExist(number1, number2, number3))
  {
    Console.Write("да");
  }
  else 
  {
    Console.Write("нет");
  }

