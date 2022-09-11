// // ЗАчада 24
// Console.Clear();
// Console.Write("Введите число: ");
// int b = int.Parse(Console.ReadLine());
// int sum = 0;
// bool a = true;
// while( a == true)
// {
//     if ( b == 0 ) 
//     {
//         Console.WriteLine("Это число не подходит");
//         Console.Write("Введите число: ");        
//         int b3 = int.Parse(Console.ReadLine());
//         if (b3 == 0)
//         {
//             Console.WriteLine("Это число не подходит");
//             Console.Write("Больше проверять не буду, устала)");        
//         }
//         else if( b < 0 )
//         {
//             Console.Write("Это число отрицательное, но можем сделать сумму положительных чисел: ");
//             for(int d = 0 ; d <= -b3 ; d++)
//             {
//                 sum = sum + d; 
//             }
//             Console.Write($"{b3} -> {sum}");
//             a = false;
//         }
//         else
//         {
            
//             for(int d = 0 ; d <= b3 ; d++)
//         {
//             sum = sum + d; 
//         }
//         Console.Write($"{b3} -> {sum}");
//         a = false; 
//         }
//     }
//     else if (b < 0)
//     {
//         Console.Write("Это число отрицательное, но можем сделать сумму положительных чисел: ");        
//         for(int x = 0 ; x <= -b ; x++)
//         {
//             sum = sum + x; 
//         }
//         Console.Write($"{b} -> {sum}");
//         a = false;
//     }
//     else
//     {
//         for(int i = 0 ; i <= b ; i++)
//         {
//             sum = sum + i; 
//         }
//         Console.Write($"{b} -> {sum}");
//         a = false;
//     }
//     a = false;
// }


// Тут без зацикливания и проверки, было лень))
// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int sum = 0;
// int Numbersum(int num)
// {
//     while(number>0)
//     {
//         sum = sum + number;
//         number--;
//     }
//     return sum;
// }
// Console.Write($"{number} -> {Numbersum(number)}");