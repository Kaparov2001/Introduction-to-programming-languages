Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Input(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}
// int value = Input("Введите основание = ");
// int value2 = Input("Введите степень = ");
// int result=1;
// for(int i = 0;i<value2;i++)
// {
//     result*=value;
// }
// Console.WriteLine($"{value} в степени {value2} = {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int value = Input("Введите число = ");
// int value2 = value;
// int result=0;
// while(value>0)
// {
//     result += value % 10;
//     value = value / 10;
// }
//  Console.WriteLine($"{value2} -> {result}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Console.WriteLine("Дайте значаение элементам массива");
for(int i=0;i<array.Length;i++)
{
    Console.Write($"arr[{i+1}] = ");
    array[i]= int.Parse(Console.ReadLine()); 
}
Console.Clear();
Console.Write("[");
for(int i=0;i<array.Length;i++)
{
    Console.Write($"{array[i]}, ");
}
Console.Write("]");