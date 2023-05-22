void FillArray(int[,] matrix,int minValue = 0, int maxValue = 9)
{
    Random random = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = random.Next(minValue, maxValue); 
        }
    }
}
void PrintArray(int[,] matrix)
{
    Console.WriteLine("Печать матрицы:");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.Write("\n");
    }
}
//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Task54()
{
    int rows = 4;
    int colums = 5;
    int temp;
    int [,] matrix = new int [rows,colums];
    FillArray(matrix);
    PrintArray(matrix);
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int k = 0; k < matrix.GetLength(0); k++)
            {
                if(matrix[i,j]<matrix[k,j])
                {
                    temp=matrix[i,j];
                    matrix[i,j]=matrix[k,j];
                    matrix[k,j]=temp;
                }
            }

        }
    }
    Console.Write("\nОтсортированная матрица\n");
    PrintArray(matrix);
}
//Task54();

//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void Task56()
{
    int rows = 4;
    int colums = 5;
    int minSum = int.MaxValue;
    int minSumRow = 0;
    int sum=0;
    int [,] matrix = new int [rows,colums];
    FillArray(matrix);
    PrintArray(matrix);
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum+=matrix[i,j];
        }
        if(sum<minSum)
        {
            minSum=sum;
            minSumRow=i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой = {minSumRow} \nСумма элементов в этой строке = {minSum}");
}
//Task56();

//Задача 61: Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
void Task61()
{
    int rows = 3;
    int colums = 3;
    int [,] matrix1 = new int [rows,colums];
    int [,] matrix2 = new int [rows,colums];
    int [,] result = new int [rows,colums];
    int sum = 0;
    FillArray(matrix1);
    Console.WriteLine("(Первая матрица):");
    PrintArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine("(Второй матрица):");
    PrintArray(matrix2);
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            sum = 0;
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum+=matrix1[i,k] * matrix2[k,j]; 
            }
            result[i,j]=sum;
        }
    }
    Console.Write("(Умноженная матрица):");
    PrintArray(result);
}
Task61();