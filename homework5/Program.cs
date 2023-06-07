// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
Console.Write("Задайте длинну массива в виде целого положительного числа: ");
int length = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(length);
Console.WriteLine(string.Join(", ", array));

Count(array);


int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    
    return array;
}


void Count(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
            count = count + 1;
    }
    Console.Write($"Количество чётных чисел в массиве: {count}");
}
*/

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
Console.Write("Задайте длинну массива в виде целого положительного числа: ");
int length = int.Parse(Console.ReadLine());

int[] array = GetRandomArray(length);
Console.WriteLine(string.Join(", ", array));

SumNumbers(array);


int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
    
    return array;
}


void SumNumbers(int[] Array)
{
    int sumNum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumNum = sumNum + array[i];
        }
    }
    Console.Write($"Сумма элементов, стоящих на нечётных позициях.: {sumNum}");
}
*/

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*
Console.Write("Задайте длину массива в виде целого положительного числа: ");
int length = int.Parse(Console.ReadLine());

double[] array = GetUserArray(length);
Console.WriteLine(string.Join(", ", array));

SumMaxMin(array);

double[] GetUserArray(int length)
{
    double[] array = new double[length];

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива, в виде вещественного числа: ");
        array[i] = double.Parse(Console.ReadLine());
    }

    return array;
}


void SumMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.Write($"Сумма минимального и максимального элементов массива: {Math.Round((min + max), 1)}");
}
*/

