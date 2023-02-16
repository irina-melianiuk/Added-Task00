// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно 2, то прорамма выводит остаток от деления.
// 34,5 -- не кратно, остаток 4
// 16,4 -- кратно


Console.Write("Введите число 1 - ");
int number1 = Convert.ToInt32(Console.ReadLine());   
Console.Write("Введите число 2 - ");
int number2 = Convert.ToInt32(Console.ReadLine());  

int result = Kratno(number1, number2);

if (result == 0)
  Console.Write($"Число {number1} по отношению к числу {number2} кратно");
else
  Console.Write($"Число {number1} по отношению к числу {number2} не кратно, остаток:  {result}");



int Kratno (int num1, int num2)
{
int kratno = num1%num2;
    return kratno; 
}

 
 
