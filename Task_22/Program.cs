// 

Console.WriteLine("Введите число N-- ");
int number = Convert.ToInt32(Console.ReadLine());

Square (number);

void Square (int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index,5}  -  {index*index,5}");
        index++;
    }
}
