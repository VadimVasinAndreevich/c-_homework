// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GenerateRandom2DArray(m,n);
PrintArrayElement(array);
OrderArrayElement(array);
Console.WriteLine();
PrintArrayElement(array);

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


void OrderArrayElement(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var x = j; x < array.GetLength(1); x++)
            {
                if(array[i,j] < array[i,x])
                {
                    int tmp = array[i,x];
                    array[i,x] = array[i,j];
                    array[i,j] = tmp; 
                }
            } 
        }
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
*/

// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

/*
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное предельное число для заполнения массива: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GenerateRandom2DArray(m,n,x);
PrintArrayElement(array);
Console.WriteLine();
SumArrayElement(array,n,x);


int[,] GenerateRandom2DArray(int m, int n, int x)
{
    int[,] array = new int[m,n]; 

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,x);
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


void SumArrayElement(int[,] array, int n, int x)
{
    int result = x*n;
    int numberRow = 1;
    for (var i = 0; i < array.GetLength(0); i++)
    {
        int sumElement = 0;
        for (var j = 0; j < array.GetLength(1); j++)
        {
            sumElement += array[i,j];
        }
        if(sumElement < result)
        {
            result = sumElement;
            numberRow = 1 + i;
        }
    }
    Console.Write($"Наименьшая сумма элементов в {numberRow}-й строке");
}
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
if(m != n)
{
    Console.WriteLine("Создать новый массив на произведении двух созданных не получится");
}
else
{
    int[,] array = GenerateRandom2DArray(m,n);
    PrintArrayElement(array);
    Console.WriteLine();
    int[,] array1 = GenerateRandom2DArray(m, n);
    PrintArrayElement(array1);
    Console.WriteLine();
    NewArrayElement(array, array1, m, n);
}


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


void NewArrayElement(int[,] array, int[,] array1, int m, int n)
{
    int[,] array2 = new int[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array2[i, j] = 0;
            for (int x = 0; x < array.GetLength(1); x++)
            {
                array2[i, j] += array[i, x] * array1[x, j];
            }
            Console.Write($"{array2[i,j]} "); 
        }
        Console.WriteLine();
    }
}
*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

/*
int[,,] array = Generate3DArray(2,2,2,8);
Console.WriteLine();
PrintArrayElement(array);

int[,,] Generate3DArray(int x, int m, int n, int length)
{
    int[,,] array = new int[x,m,n]; 

    Random random = new Random();
    int[] arrayTest = new int[length];
    int a = 0;
    while(a != arrayTest.Length)
    {
        int num = random.Next(10, 100);
        int count = 0;
        for (var k = 0; k < arrayTest.Length; k++)
        {
            if (arrayTest[k] == num)
            {
                count++;
            }
        }
        if(count == 0)
        {
            arrayTest[a] = num;
            Console.Write($"{arrayTest[a]} ");
            a++;
        }
    }
    for (var b = 0; b < arrayTest.Length;)
    {
        for (var r = 0; r < array.GetLength(0); r++)
        {
            for (var i = 0; i < array.GetLength(1); i++)
            {
                for (var j = 0; j < array.GetLength(2); j++)
                {
                    array[i, j, r] = arrayTest[b];
                    b++;
                }
            }
        }   
    }
    return array;
}


void PrintArrayElement(int[,,] array)
{
    for (var r = 0; r < array.GetLength(0); r++)
    {
        for (var i = 0; i < array.GetLength(1); i++)
        {
            for (var j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[i,j,r]}({i},{j},{r}) ");
            }
            Console.WriteLine();
        }
    }
}
*/

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

/*
int[,] array = GenerateSpiral2DArray(4,4);
PrintArrayElement(array);

int[,] GenerateSpiral2DArray(int m, int n)
{
    int[,] array = new int[m,n]; 

    int count = 1;
    for (var j = array.GetLength(1) - 4; j < array.GetLength(1); j++)
    {
        array[array.GetLength(1) - 4, j] = count;
        count++;
    }
    for (var i = array.GetLength(0) - 3; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1) - 1] = count;
        count++;
    }
    for (var j = array.GetLength(1) - 2; j >= array.GetLength(1) - 4; j--)
    {
        array[array.GetLength(0) - 1, j] = count;
        count++;
    }
    for (var i = array.GetLength(0) - 2; i >= array.GetLength(0) - 3; i--)
    {
        array[i, array.GetLength(1) - 4] = count;
        count++;
    }
    for (var j = array.GetLength(1) - 3; j < array.GetLength(1) - 1; j++)
    {
        array[array.GetLength(0) - 3, j] = count;
        count++;
    }
    for (var i = array.GetLength(0) - 2; i >= array.GetLength(0) - 2; i--)
    {
        array[i, array.GetLength(1) - 2] = count;
        count++;
    }
    for (var j = array.GetLength(1) - 3; j >= array.GetLength(1) - 3; j--)
    {
        array[array.GetLength(0) - 2, j] = count;
        count++;
    }
    return array;
}

void PrintArrayElement(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
            {
                Console.Write($"{0}{array[i,j]} ");
            }
            else
            {
                Console.Write($"{array[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}
*/