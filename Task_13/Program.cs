// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next();  
 Console.WriteLine($"Случайное число => {number}");

 int resDigit = ThirdDigit(number);
 int bigDigit = Third2Digit(number);
 

 if ((number > 99) && (number < 999 ))
   {
    Console.WriteLine($"Третья цифра числа = {resDigit}");
   }
 else 
   {
     if (number < 99)
       Console.WriteLine($"Третья цифра числа отсутствует");
     else
       Console.WriteLine($"Третья цифра числа = {bigDigit}");
   }
      
  
int ThirdDigit(int num)
{  
      int thirdDigit = num % 10; 
      return (thirdDigit);
}

int Third2Digit(int num2)
{  
      while (num2 >= 999)
      {
        num2 = num2 / 10; 
        //return (num2);
      }
      int Third2Digit = num2 / 10;
      //int LastDigit = Third2Digit % 10; 
      //return (LastDigit);
      return (num2 - Third2Digit*10);
}