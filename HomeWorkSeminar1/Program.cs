//  Домашнее задание 1

//  Задача 1
/*  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    a = 5; b = 7 -> max = 7
    a = 2 b = 10 -> max = 10
    a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Input number 1:");
int numb1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number 2:");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1 > numb2) 
{
    Console.WriteLine($"The first number ({numb1}) is greater and the second number ({numb2}) is less");
}
else if (numb1 == numb2) Console.WriteLine($"The first number ({numb1}) is equal to the second number ({numb2})");
else Console.WriteLine($"First number ({numb1}) is less and second number ({numb2}) is greater");
*/

/*  Задача 2
//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/

/*
int maxNumb = 0;
int currNumb;
int countOfNumb = 3;

for (int i = 1; i <= countOfNumb; i++)
{
    Console.Write($"Input number {i}:");
    currNumb = Convert.ToInt32(Console.ReadLine());
    if (i == 1) maxNumb = currNumb;
    if (currNumb > maxNumb)
    {
        maxNumb = currNumb;
    }
}

Console.WriteLine($"Max number is {maxNumb}");
*/


/*  Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
    (делится ли оно на два без остатка).

    4 -> да
    -3 -> нет
    7 -> нет
*/

/*
Console.Write("Input number:");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb%2 == 0) Console.Write($"Number ({numb}) is even");
else Console.Write($"Number ({numb}) is odd");
*/

/*  Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает
    все чётные числа от 1 до N.

    5 -> 2, 4
    8 -> 2, 4, 6, 8
*/

Console.Write("Input number:");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb < 2) Console.WriteLine($"For the number ({numb}) there are no even numbers greater than 1");
else
{
    for (int i = 2; i <= numb; i += 2)
    {
        Console.Write(i);

        if (i + 2 <= numb) Console.Write(", ");
    }
}
