// Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*
Console.WriteLine("Введите два числа:");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    Console.Write("max = ");
    Console.Write(numberA);
}
else
{
    Console.Write("max = ");
    Console.Write(numberB);
}
*/

// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22 

/*
Console.WriteLine("Введите три числа:");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
if(numberA > numberB)
{
    if(numberA > numberC)
    {
        Console.Write("max = ");
        Console.Write(numberA);
    }
}
if(numberB > numberA)
{
    if(numberB > numberC)
    {
        Console.Write("max = ");
        Console.Write(numberB);
    }
}
if(numberC > numberA)
{
    if(numberC > numberB)
    {
        Console.Write("max = ");
        Console.Write(numberC);
    }
}
else
{
    Console.WriteLine("Все числа равны между собой");
    Console.Write("max = ");
    Console.Write(numberA);
}
*/

// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

/*
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
if(number % 2 == 0)
{
    Console.Write(number);
    Console.Write(" - является четным числом");
}
else
{
    Console.Write(number);
    Console.Write(" - не является четным числом");
}
*/

// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

/*
Console.WriteLine("Введите целое число больше или равно 1:");
int numberN = int.Parse(Console.ReadLine());
int count = 1;
while(count <= numberN)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
        if(count < numberN - 1)
        {
            Console.Write(", ");
        }
    }
    count += 1; 
}
if(numberN < 1)
{
    Console.WriteLine("Программа не выполнится, т.к. введенное число меньше 1");    
}
*/