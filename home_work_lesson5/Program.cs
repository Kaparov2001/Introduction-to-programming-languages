Console.Clear();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] createArray(int length, int leftSide, int rightSide)
{
    int[] array = new int[length];
    Random random = new Random();
    for(int i = 0; i < array.Length;i++)
        array[i] = random.Next(leftSide,rightSide);
    return array;
}
void PrintArray(int[] array)
{
    foreach (int element  in array)
        Console.Write($"{element} ");
}
// int[] array = createArray(5,100,999);
// PrintArray(array);
// int result=0;
// for(int i = 0;i < array.Length;i++)
// {
//     if(array[i]%2==0)
//     {
//         result++;
//     }
// }
// Console.Write($"\nКоличество четных чисел = {result}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = createArray(6,0,999);
// PrintArray(array);
// int result = 0;
// for(int i = 0;i<array.Length;i++)
// {
//     if(i%2!=0)
//     {
//         result += array[i];
//     }
// }
// Console.WriteLine($"\n {result}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[8];
Random random = new Random();
double minValue = 1.0;
double maxValue = 100.0;
double min = double.MaxValue, max = 0; 
for(int i = 0; i < array.Length;i++)
{
    array[i] = Math.Round(minValue + (maxValue - minValue) * random.NextDouble(),3);
    Console.Write($"{array[i]}; ");
    if(min > array[i])
        min = array[i];
    if(max < array[i])
        max = array[i];
}
Console.WriteLine($"\nРазница между макс и мин элементом массива = {Math.Round(max-min,3)}");