Console.Clear();
Console.Write("\nЗадача 2 под номером - 1 \nЗадача 4 под номером - 2 \nЗадача 6 под номером - 3 \nЗадача 8 под номером - 4 \nВыход - 5 \nВыберите задание: ");
bool loopBreak=true;
string input; // считываем ввод пользователя
int number;
while (loopBreak)
{
    //int number = int.Parse(Console.ReadLine()); 
    input = Console.ReadLine();
    if (int.TryParse(input, out number))
    {

    }else
    {
        // Если пользователь ввел не число, выведется сообщение об ошибке
        Console.WriteLine("Ошибка: вы ввели не число.");
    }
    switch (number)
    {
        case 1:
            /*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
                        какое число большее, а какое меньшее.*/
            Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");
            Console.Write("Задайте первое значение ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Задайте второе значение ");
            int b = int.Parse(Console.ReadLine());

            if(a>b)
            {
                Console.WriteLine($" Большее число = {a} \n Меньшее число = {b}");
            }else if(a==b)
            {
                Console.WriteLine("Первое и второе значение равны");
            }else
            {
                Console.WriteLine($" Большее число = {b} \n Меньшее число = {a}");
            }
            break;
        case 2:
            /*Задача 4: Напишите программу, которая принимает на 
                        вход три числа и выдаёт максимальное из этих чисел.*/
            Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
            Console.Write("Задайте первое значение ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Задайте второе значение ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Задайте третье значение ");
            int e = int.Parse(Console.ReadLine());

            if(c>d && c>e) 
            {
                Console.WriteLine($" Первое значение максимальное = {c}");
            }else if(d>c && d>e)
            {
                Console.WriteLine($" Второе значение максимальное = {d}");
            }
            else if(c==d && c==e)
            {
                Console.WriteLine("Они равны");
            }else
            {
                Console.WriteLine($" Третье значение максимальное = {d}");
            }
            break;
        case 3:
            /*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
                        является ли число чётным (делится ли оно на два без остатка).*/
            Console.WriteLine("Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
            Console.Write("Задайте значение ");
            int number2 = int.Parse(Console.ReadLine());

            if(number2%2==0)
            {
                Console.Write($"{number2} Четное, делитсяна два без остатка ");
            }else
            {
                Console.Write($"{number2} Нечетное, не делитсяна два без остатка ");
            }
            break;
        case 4:
            /*Задача 8: Напишите программу, которая на вход принимает число (N), 
                        а на выходе показывает все чётные числа от 1 до N.*/
            Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
            Console.Write("Задайте значение ");
            int newNumber = int.Parse(Console.ReadLine());
            for(int i=1;i<newNumber;i++)
            {
                if(i%2==0)
                {
                    Console.Write($"{i} ");
                }
            }
            break;
        case 5:
            Console.Write("Выход ");
            loopBreak = false;
            break;
        default:
        Console.WriteLine("Вы ввели не правильный номер!");
        break;
    
    }
    if(loopBreak!=false )
    {
        Console.WriteLine("\n\nЗадача 2 под номером - 1 \nЗадача 4 под номером - 2 \nЗадача 6 под номером - 3 \nЗадача 8 под номером - 4 \nВыход - 5 \nВыберите задание: ");
    }
}