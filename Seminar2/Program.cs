/*int CutNumber(int number)
{
    int leftNumber = number / 100;
    int rightNumber = number % 10;

    return leftNumber * 10 + rightNumber;

}

int num = new Random().Next(100, 1000);

Console.WriteLine($"{num}  ->  {CutNumber(num)}");
*/

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*int MaxOfNumb(int number)
{
    int leftNumber = number / 10;
    int rightNumber = number % 10;

    if (leftNumber>rightNumber) return leftNumber;
    else return rightNumber;
}

int number = new Random().Next(10, 100);
Console.WriteLine($"{number} -> {MaxOfNumb(number)}");
*/



//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool MultipleFirstNumbToSecondNumb(int firstNumb, int secondNumb)
{   
    return firstNumb%secondNumb == 0;
}

Console.Write("Please, input number one:");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input number two:");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(MultipleFirstNumbToSecondNumb(firstNumb, secondNumb));
*/
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool IsSQRT(int firstNumb, int secondNumb)
{
    return firstNumb*firstNumb == secondNumb || secondNumb*secondNumb == firstNumb;
}

Console.Write("Please, input number one:");
int firstNumb = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input number two:");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSQRT(firstNumb, secondNumb));

