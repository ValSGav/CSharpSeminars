/*int a = 1;
double b = 3.333234;
bool c = true;
string d = "Hello";

Console.WriteLine(d + " kak dela " + c + " smotri " + b);
Console.WriteLine($"{d} kak dela {c} smotri {b}");
*/



//  Семинар 1
//  Задача 1
//  Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

/*
Console.Write("Please, input two number:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine("First number is a SQRT of second number!");
}
else
{
    Console.WriteLine("First number is NOT a SQRT of second number!");
}
*/
//  Задача 2
//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.Write("Please, input a number:");
int n = Convert.ToInt32(Console.ReadLine());
int curr = -n;

while (curr <= n)
{
    Console.Write(curr + " ");
    curr++;
}


//  Задача 3
//  
// 34567 / 10 = 3456
// 34567 / 100 = 345
// 34567 / 1000 = 34
// 34567 / 10000 = 3

// 34567 % 10 = 7
// 34567 % 100 = 67
// 34567 % 1000 = 567
// 34567 % 10000 = 4567

// 38513452375 ->  34

// 34513452345 / 100000 % 100