// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
Console.Write("Введите целое положительное число: ");
int numberOperation = int.Parse(Console.ReadLine());

PrintNumbers(numberOperation);

void PrintNumbers(int numberOperation)
{
    int number = numberOperation - 1;
    if (numberOperation < 2)
    {
        Console.Write($"{numberOperation} ");
        return; 
    }
    if (numberOperation >= 2)
    {
        Console.Write($"{numberOperation}, ");
    }
    PrintNumbers(number);     
}
*/

// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/*
Console.Write("Введите целое число - начало интервала: ");
int numberBeginInterval = int.Parse(Console.ReadLine());
Console.Write("Введите целое число - конец интервала: ");
int numberEndInterval = int.Parse(Console.ReadLine());
int numberSum = 0;

SumNumbersInRange(numberBeginInterval, numberEndInterval, numberSum);

void SumNumbersInRange(int numberBeginInterval, int numberEndInterval, int numberSum)
{
    if (numberBeginInterval > numberEndInterval)
    {
        Console.Write($"Сумма натуральных элементов в промежутке: {numberSum}");
        return;
    }
    numberSum += numberBeginInterval;
    SumNumbersInRange(++numberBeginInterval, numberEndInterval, numberSum);
}
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
Console.Write("Введите целое положительное число M: ");
int numberM = int.Parse(Console.ReadLine());
Console.Write("Введите целое положительное число N: ");
int numberN = int.Parse(Console.ReadLine());
*/

/*
int result = Akkerman(numberM, numberN);
Console.WriteLine($"A({numberM},{numberN}) = {result}");

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 & numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}
*/

// или такой вариант

/* 
AkkermanFunction(numberM, numberN);

void AkkermanFunction(int numberM, int numberN)
{
    Console.WriteLine($"A({numberM},{numberN}) = {Akkerman(numberM, numberN)}"); 
}


int Akkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return Akkerman(numberM - 1, 1);
    }
    else
    {
        return (Akkerman(numberM - 1, Akkerman(numberM, numberN - 1)));
    }
}
*/

