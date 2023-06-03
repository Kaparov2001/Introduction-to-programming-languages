Console.Clear();
//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void Task64(int endNumber,int startNumber = 1)
{
    if(endNumber < startNumber) return;
    Console.Write($"{endNumber} ");
    endNumber--;
    Task64(endNumber,startNumber);
}
// Console.Write("Задайте значение N= ");
// int number = int.Parse(Console.ReadLine());
// Task64(number);

//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void Task66(int endNumber,int startNumber = 1,int sum = 0)
{
    if(endNumber < startNumber)
    {
        Console.Write($"M = {startNumber/startNumber}; N = {endNumber} ->{sum}");
        return;
    } 
    sum += startNumber;
    startNumber++;
    Task66(endNumber,startNumber,sum);
}
// Console.Write("Задайте значение M = ");
// int M = int.Parse(Console.ReadLine());
// Console.Write("Задайте значение N = ");
// int N = int.Parse(Console.ReadLine());
// Task66(N,M);

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
static int Task68(int M,int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0)
        return Task68(M - 1, 1);
    else
        return Task68(M - 1, Task68(M, N - 1));
}
Console.Write("Введите значение m: ");
int M = int.Parse(Console.ReadLine());

Console.Write("Введите значение n: ");
int N = int.Parse(Console.ReadLine());
if(N > 0 && M > 0)
{
    int result = Task68(M, N);
    Console.WriteLine($"Результат = {result}");
}