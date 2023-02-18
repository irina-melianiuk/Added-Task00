// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber(int number)
{
    if (number < 100000)
    {
        Console.WriteLine("Число проверяется на палиндромность.");
        return true;
    }
    else
        return false;
}

int Upheaval (int number)
{
    int firstDigit = number%10;
    int secondDigit = number%100/10;
    int thirdDigit = number%1000/100;
    int fourthDigit = number%10000/1000;
    int fifthDigit = number/10000;
    int newNumber = firstDigit*10000 + secondDigit*1000 + thirdDigit*100 + fourthDigit*10 + fifthDigit;
    return newNumber;
}

int number = Promt("Введите пятизначное число >  " );
if (ValidateNumber(number))
{
    if (number == Upheaval(number))
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
        Console.WriteLine($"Число {number} не является палиндромом.");
}
else
 Console.WriteLine("Вы ввели не пятизначное число.");

