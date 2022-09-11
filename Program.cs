// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
Console.Clear();
int[] array = new int [8];
void Random_array(int[] arr)
{
    int index = 0;
    Console.Write("[");
    while ( index < arr.Length-1)
    {
        arr[index] = new Random().Next(0 , 2);
        Console.Write($"{arr[index]} , ");
        index++;
    }
   
    Console.Write($"{arr[index]} ");
     Console.Write("]");

}

Random_array(array);


