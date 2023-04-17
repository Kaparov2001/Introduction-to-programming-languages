Console.Clear();
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// int value;
// int[] number = new int[5];
// bool LoopBreak=true;
// Console.Write("Задайте  элемент: ");
// while(LoopBreak)
// {    
//     value = int.Parse(Console.ReadLine());
//     if(value<10000 || value>99999)
//     {
//       Console.WriteLine("Вы не ввели пятизначное число\nПовторите попытку:");  
//     }else
//     {
//         for (int i = 0; i < 5; i++)
//         {
//             number[i] = value % 10;
//             value /= 10;
//         }
//         if (number[0] == number[4] && number[1] == number[3])
//         {
//             Console.WriteLine("Число является палиндромом");
//         }
//         else
//         {
//             Console.WriteLine("Число не является палиндромом");
//         }

//         LoopBreak=false;
//     }
// }

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// int[] X = new int[3];
// int[] Y = new int[3];
// double distance;
// Console.WriteLine("Введите координаты первой точки (x1 y1 z1): ");
// for (int i = 0; i < 3; i++)
// {
//     X[i]=int.Parse(Console.ReadLine());
// }
// Console.WriteLine("Введите координаты второй точки (x2 y2 z2): ");
// for (int i = 0; i < 3; i++)
// {
//     Y[i]=int.Parse(Console.ReadLine());
// }
// distance = Math.Round(Math.Sqrt(Math.Pow(X[0] - Y[0], 2) + Math.Pow(X[1] - Y[1], 2) + Math.Pow(X[2] - Y[2], 2)),2);
// Console.WriteLine($"Расстояние между точками: {distance}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Задайте  элемент N:");
double value = double.Parse(Console.ReadLine()),temp;
for(int i=0;i<=value;i++)
{
    temp=Math.Pow(i,3);
    Console.Write($"{temp}, ");
}