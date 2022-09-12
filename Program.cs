// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
int  sum_in_number(int aa)
{
    int result = 0;
    int cc = Convert.ToString(aa).Length;
    int second = 0;
    for( int i = 0 ; i < cc ; i++)
    {
        second = aa - aa % 10;
        result = result + (aa - second);
        aa = aa / 10;
    }
    return result;
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToString(a).Length;
Console.WriteLine($"{a} -> {sum_in_number(a)}");