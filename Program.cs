// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
Console.Write("Введите число: ");
string cc = Console.ReadLine();
int Countnumbers(string count)
{
    int a = cc.Length;
    return cc.Length;
}

foreach ( char i in cc)
{
    if (i == '-')
    {
        cc = cc.Replace("-" , "");
        Console.WriteLine($"-{cc} -> {Countnumbers(cc)}");
        break;
    }
    else 
    {
        Console.WriteLine($"{cc} -> {Countnumbers(cc)}");
        break;
    }
}
