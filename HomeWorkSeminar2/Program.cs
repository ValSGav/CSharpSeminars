/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*********************************************************************************************
int SecondDigitOfThreeDidgitNumber(int threeDidgitNumber)
{
    return (threeDidgitNumber / 10) % 10;

}

Console.Write("Please, input three-digit number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 100 == numb || (numb % 1000) != numb) 
// numb % 100 - для однозначных и двузначных чисел сами числа, 
//(numb % 1000) - для трехзначного числа само число, для четырехзначных и т.д. обрезанное до 3 знаков число 
    Console.WriteLine($"{numb} is not three-digit number!");
else
{
    Console.WriteLine($" {numb} -> {SecondDigitOfThreeDidgitNumber(numb)}");
}

*********************************************************************************/

/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/**************************************************************************************
int ThirdDigitOfNumber(int int_number)
{
    int cutNumber = int_number;
    while (cutNumber % 1000 != cutNumber) 
    {
        cutNumber = cutNumber/10;
    }

    return cutNumber % 10;
}

Console.Write("Please, input number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (numb % 100 == numb) 
// numb % 100 - для однозначных и двузначных чисел сами числа 
    Console.WriteLine($"{numb}: the number doesn't have a third digit!");
else
{
    Console.WriteLine($" {numb} -> {ThirdDigitOfNumber(numb)}");
}
/*********************************************************************************************

/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

bool CheckDayIsWeekend(int int_day)
{
    return int_day > 5;
}

Console.Write("Please enter a number indicating the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7) 
    Console.WriteLine("This number is not a day of the week!");
else 
    Console.WriteLine(CheckDayIsWeekend(day));