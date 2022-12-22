/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*******************************************************/
/*
bool IsPalindrom(int number)
{
    int currentNumber = number;
    int reversNumber = 0;
    int currentFigure = 0;
    while (currentNumber != 0)
    {
        currentFigure = currentNumber%10;
        reversNumber = reversNumber*10 + currentFigure; 
        currentNumber = currentNumber / 10;
    }

    return reversNumber == number;
}

Console.Write("Input a number: ");
Console.WriteLine($"Number is palindrom: {IsPalindrom(Convert.ToInt32(Console.ReadLine()))}");
*/
/*******************************************************
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
********************************************************/
/*
double GetTheDistanceBtTwoPoint3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2)), 2);
}

Console.Write("Please, input coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The distance is {GetTheDistanceBtTwoPoint3D(x1, y1, z1, x2, y2, z2)}");
*/
/********************************************************
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

**********************************************************/
void GetTableOfQube(int numb)
{
    for (int i = 1; i <= numb; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
}

Console.WriteLine("Input a number");
GetTableOfQube(Convert.ToInt32(Console.ReadLine()));
//********************************************************