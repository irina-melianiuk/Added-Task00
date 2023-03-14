// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число M");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int number2 = int.Parse(Console.ReadLine());
 Console.Write($"Результат вычисления функции Аккермана равен  {FunctionAckerman(number1, number2)} ");

 int FunctionAckerman(int num1, int num2)
 {
   if (num1 == 0) //если n = 0
   {
    return num2 + 1; //вернуть m + 1
   } 
   else
   {
    if (num2 == 0) // иначе, если m = 0
    {
      return FunctionAckerman(num1 - 1, 1); //вернуть ack (n - 1, 1)
    }
    else
    {
      return FunctionAckerman(num1 - 1, FunctionAckerman(num1, num2 - 1)); // вернуть ack(n - 1, ack (n, m - 1))
    }
   }
 }