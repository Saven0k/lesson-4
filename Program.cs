//     Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
int multiplicathion_number(int A , int B)
{
    int result = 1;
    for(int i = 1 ; i <= B ; i++)
    {
        result = result*A;
    }
    return result;
}
Console.Clear();
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число б: ");
int b = int.Parse(Console.ReadLine());
if ( b < 0)
{
    Console.WriteLine("Ошибка(число отрицательное)");
}
else
{
    Console.Write($"{a} , {b} ->  {multiplicathion_number(a , b)}");
}

