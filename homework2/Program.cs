// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*
Random random = new Random();
int randomNumber = random.Next(100,1000);
int secondDigit = (randomNumber / 10) % 10; 
Console.Write("Вторая цифра числа: ");
Console.Write(randomNumber);
Console.Write(" - ");
Console.Write(secondDigit);
*/

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*
int number = -12;
int numberIter = 0;
if(number < 0)
{
    numberIter = -number;
}
if(number >= 0)
{
    numberIter = number;
}
while(numberIter > 999)
{
    numberIter = numberIter / 10;
}
if(numberIter >= 100)
{
    numberIter = numberIter % 10;
    Console.Write("Третья цифра числа: ");
    Console.Write(number);
    Console.Write(" - ");
    Console.Write(numberIter);
}
else
{
    Console.Write("У числа: ");
    Console.Write(number);
    Console.Write(" - третьей цифры нет");
}
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
Console.WriteLine("Введите порядковый номер дня недели:");
int number = int.Parse(Console.ReadLine());
if(number > 0 & number < 8)
{
    if(number > 5 & number < 8)
    {
        Console.Write(number);
        Console.Write("-й день недели является выходным");
    }
    else
    {
        Console.Write(number);
        Console.Write("-й день недели не является выходным");
    }
}
else
{
    Console.Write("дня недели с порядковым номером ");
    Console.Write(number);
    Console.Write(" не существует");
}
*/