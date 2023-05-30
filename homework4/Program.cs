// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
Console.Write("Введите число A, которое будет возводиться в степень: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B, которое будет степенью числа A: ");
int numberB = int.Parse(Console.ReadLine());

int result = Exponentiation(numberA, numberB);

Console.WriteLine($"{numberA} в степени {numberB}, равно: {result}");


int Exponentiation(int numberA, int numberB)
{
    int count = 1;
    int resultExp = 1;
    while(numberB >= count)
    {
        resultExp = resultExp * numberA;
        count++;
    }
    return resultExp;
}
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int sumNum = SumNumbers(number);

Console.WriteLine($"сумма цифр в числе {number} равна: {sumNum}");


int SumNumbers(int number)
{
    int sumNum = 0;
    while(number != 0)
    {
        sumNum = number % 10 + sumNum;
        number = number / 10;
    }
    return sumNum;
}
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Через random

/*
Console.Write("Задайте длинну массива в виде целого положительного числа: ");
int length = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(length);

Console.WriteLine(string.Join(", ", array));


int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next();
    }

    return array;
}
*/

// Через ввод от пользователя

/*
Console.Write("Задайте длину массива в виде целого положительного числа: ");
int length = int.Parse(Console.ReadLine());
int[] array = GetUserArray(length);

Console.WriteLine(string.Join(", ", array));


int[] GetUserArray(int length)
{
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    return array;
}
*/