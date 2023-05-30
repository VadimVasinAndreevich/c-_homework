// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
if(number >= 10000 & number < 100000)
{
    int count = 10000;
    int numberCount = number;
    while(numberCount != 0)
    {
        numberCount = numberCount - (numberCount % 10) * count;
        if(numberCount > count | numberCount < 0)
        {
            Console.WriteLine($"Число: {number} - не является полиндромом");
            break;
        }
        count = count / 100;
        numberCount = numberCount / 10;
    }
    if(numberCount == 0)
    {
        Console.WriteLine($"Число: {number} - является полиндромом");
    }
    
}
else
{
    Console.WriteLine($"Число: {number} - не соответствует требованиям");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
Console.Write("Введите значение x для точки A:");
int xA = int.Parse(Console.ReadLine());
Console.Write("Введите значение y для точки A:");
int yA = int.Parse(Console.ReadLine());
Console.Write("Введите значение z для точки A:");
int zA = int.Parse(Console.ReadLine());
Console.Write("Введите значение x для точки B:");
int xB = int.Parse(Console.ReadLine());
Console.Write("Введите значение y для точки B:");
int yB = int.Parse(Console.ReadLine());
Console.Write("Введите значение z для точки B:");
int zB = int.Parse(Console.ReadLine());

double distance = DistanceBetweenTwoPoints(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между двумя точками: {Math.Round(distance, 2)}");

double DistanceBetweenTwoPoints(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow(xB - xA, 2)  + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
}
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
Console.WriteLine("Введите целое положительное число больше 1:");
int number = int.Parse(Console.ReadLine());

int[] result = GetTableOfSquares(number);
Console.WriteLine(string.Join(", ", result));


int[] GetTableOfSquares(int number)
{
    int[] TableOfSquares = new int[number];
    for(int i = 0; i < TableOfSquares.Length; i++)
    {
        int tmp = i + 1;
        TableOfSquares[i] = tmp * tmp * tmp;
    } 
    return TableOfSquares; 
}
*/

