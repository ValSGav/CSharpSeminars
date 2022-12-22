/*void GetDiapazon(int quadrant)
{
    if (quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if (quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if (quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if (quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input!");
}

Console.WriteLine("Input a number of quadrant: ");
GetDiapazon(Convert.ToInt32(Console.ReadLine()));
*/

//1.    Напишите программу, которая принимает на вход координаты точки (X и Y), 
//      причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int GetQuadrant(double x, double y)
{
    int quadrant = 0;
    if (x>0)
    {
        if(y>0) quadrant = 1;
        else quadrant = 4;

    }
    else
    {
        if(y>0) quadrant = 2;
        else quadrant = 3;
    }

    return quadrant;
}

Console.WriteLine("Please, input coordinates x and y");
double x = Convert.ToDouble(Console.ReadLine());
double y = Convert.ToDouble(Console.ReadLine());

if (x == 0 ||y ==0) Console.WriteLine("Wrong coordinates");
else Console.WriteLine(GetQuadrant(x, y));
*/

//2.    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void GetTableOfSquare(int numb)
{
    for (int i = 1; i <= numb; i++)
    {
        Console.Write(i * i + " ");
    }
}

Console.WriteLine("Input a number");
GetTableOfSquare(Convert.ToInt32(Console.ReadLine()));
*/

//3.    Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
//      в 2D пространстве.

double GetTheDistanceBtTwoPoint(double xa, double ya, double xb, double yb)
{
    return Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2)), 2);
}

Console.Write("Please, input coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, input coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The distance is {GetTheDistanceBtTwoPoint(x1, y1, x2, y2)}");