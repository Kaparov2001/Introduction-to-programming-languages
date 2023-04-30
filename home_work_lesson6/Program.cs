Console.Clear();
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// List<int> list = new List<int>();
// int input,result=0;
// Console.WriteLine("Введите элементы массива (введите -999 для завершения):");
// do
// {
//     input = int.Parse(Console.ReadLine());
//     if (input != -999)
//     {
//         list.Add(input);
//     }
//     if(input>0)
//     {
//         result++;
//     }
// }
// while (input != -999);

// Console.WriteLine("Массив:");
// foreach (int element in list)
// {
//     Console.Write(element + " ");
// }
// Console.WriteLine($"\n Числа больше 0 = {result});

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);

double y = k1 * x + b1;
double y2 = k2 * x + b2;
Console.WriteLine($"Точка пересечения: ({y}, {y2})");