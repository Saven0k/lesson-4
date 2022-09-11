// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 1;
int Num_multiplication(int num)
{
    for (int i = 1 ; i <= num ; i++)
    {
        sum = sum * i;
    }
    return sum;
}

if(number % 2 == 0 )
{
    if (number<0)
    {
        int number1 = Math.Abs(number);
        Console.Write($"{number} -> {Num_multiplication(number1)}");
    }
    else
    {
        Console.Write($"{number} -> {Num_multiplication(number)} ");
    }
} 

else 
{
    if (number<0)
    {
        Console.WriteLine("Ошибка");
    }
    else
    {
        Console.Write($"{number} -> {Num_multiplication(number)} ");
    }
}

