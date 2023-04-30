Console.Clear();
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Random random = new Random();
// double [,] array = new double [3,4];
// double minValue = 1.0;
// double maxValue = 100.0;
// for(int i = 0; i< array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             array[i,j] = Math.Round(minValue + (maxValue - minValue) * random.NextDouble(),3);
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.WriteLine("Введите номер строки: ");
// int row = int.Parse(Console.ReadLine()); 

// Console.WriteLine("Введите номер столбца: ");
// int col = int.Parse(Console.ReadLine());
// int test=0;
int[,] CreateArray()
{
    int[,] array = new int[4,5];
    for(int i = 0; i< array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(100);
        }
    } 
    return array;
}
void PrintArray(int [,] array)
{
    for(int i = 0; i< array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
}
// int [,] array = CreateArray();
// PrintArray(array);
// for(int i = 0; i< array.GetLength(0);i++)
// {
//     for(int j = 0; j < array.GetLength(1);j++)
//     {
//         if(i == row && j == col)
//         {
//             test++;
//         }
//     }
// }
// if(test==1)
// {
//   Console.WriteLine($"Значение элемента ({row}, {col}): {array[row,col]}");  
// }else
// {
//     Console.WriteLine($"Элемента ({row}, {col}) не существует.");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
double temp=0;
int [,] array = CreateArray();
PrintArray(array);
Console.WriteLine();
for(int j = 0; j< array.GetLength(1);j++)
{
    temp=0;
    for(int i = 0; i < array.GetLength(0);i++)
    {
        temp+=array[i,j];
    }
    temp/= array.GetLength(0);
    Console.Write($"{Math.Round(temp,3)} "); 
}
