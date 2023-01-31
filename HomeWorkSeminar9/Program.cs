/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void ShowNaturalNumbsBetweenNandOne(int n)
{
    Console.Write($"{n} ");
    if (n > 1) ShowNaturalNumbsBetweenNandOne(n-1);    
}


Console.Write("Input a numb: ");
int numb = Convert.ToInt32(Console.ReadLine());
ShowNaturalNumbsBetweenNandOne(numb);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetSumOfNaturalNumbsBetweenTwoNumbs(int firstNumb, int secondNumb)
{
    if (firstNumb > secondNumb) return firstNumb + GetSumOfNaturalNumbsBetweenTwoNumbs(firstNumb - 1, secondNumb);
    if (firstNumb < secondNumb) return firstNumb + GetSumOfNaturalNumbsBetweenTwoNumbs(firstNumb + 1, secondNumb);
    return firstNumb;
}

/*
Console.Write("Input first numb: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second numb: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numb between {firstNumb} and {secondNumb} is {GetSumOfNaturalNumbsBetweenTwoNumbs(firstNumb, secondNumb)}");
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

//По определению Рожа Петер

//A(0,m)=m+1
//A(n+1,0)=A(n,1)
//A(n+1,m+1)=A(n,A(n+1,m))

int GetResultArrermanFunc(int n, int m)
{
    if (n == 0) return m + 1;
    if (m == 0) return GetResultArrermanFunc(n - 1, 1);
    return GetResultArrermanFunc(n - 1, GetResultArrermanFunc(n, m - 1));
}

Console.WriteLine("Сalculating the Akkerman function.");
Console.Write("Input first numb: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second numb: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetResultArrermanFunc(firstNumb,secondNumb));