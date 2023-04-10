Console.Clear();
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
// int Input(string message)
// {
//     Console.Write(message);
//     int value = int.Parse(Console.ReadLine());
//     return value;
// }
// int number = Input("Введите трехзначное число:");
// if(number<100 || number>999)
// {
//     Console.WriteLine("Вы не ввели трехзначное число:");
//     return;
// }
// Console.WriteLine($"Вы ввели: {number}");
// number = number / 10 % 10;
// Console.WriteLine($"Вторая цифра ровна = {number}");

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Write("Введите число: ");
// string str = Console.ReadLine();
// int value = Convert.ToInt32(str[2].ToString());
// Console.Write($"Третья цифра ровна = {value}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine());
if(value>7 || value <0)
{
    Console.WriteLine("Нет такой день недели ");
}else
{
    if(value<6)
    {
        Console.WriteLine($"{value} -> НЕТ");
    }else
    {
        Console.WriteLine($"{value} -> Да");
    }
}