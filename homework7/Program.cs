// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double[,] array = GenerateRandom2DArray(m,n);

PrintArray(array);

void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:F1} ");
        }
        Console.WriteLine();
    }
}

double[,] GenerateRandom2DArray(int m, int n)
{
    double[,] array = new double[m,n]; 

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(-100,100) * 0.1;
        }
    }
    return array;
}
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GenerateRandom2DArray(m,n);
PrintArrayElement(array);
PrintArrayIndex(array);

Console.Write("Введите i-ую позицию массива: ");
int i = int.Parse(Console.ReadLine());
Console.Write("Введите j-ую позицию массива: ");
int j = int.Parse(Console.ReadLine());

PositionsElement(array);


int[,] GenerateRandom2DArray(int m, int n)
{
    int[,] array = new int[m,n]; 

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }
    return array;
}


void PrintArrayIndex(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"({i},{j}) ");
        }
        Console.WriteLine();
    }
}


void PrintArrayElement(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


void PositionsElement(int[,] array)
{
    if(i < array.GetLength(0) & j < array.GetLength(1))
    {
       Console.WriteLine($"Элемент с позициями в массиве ({i},{j}): {array[i,j]}"); 
    }
    else
    {
        Console.WriteLine($"Элемента с позициями ({i},{j}) в массиве не существует");
    }
}
*/

// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GenerateRandom2DArray(m,n);
PrintArrayElement(array);

SumMeanElementOfPost(array);


int[,] GenerateRandom2DArray(int m, int n)
{
    int[,] array = new int[m,n]; 

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
        }
    }
    return array;
}


void PrintArrayElement(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


void SumMeanElementOfPost(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0):F1} ");
    }
}
*/