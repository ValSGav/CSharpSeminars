//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
void ShowNubersNatural(int n)
{
    if (n > 1) ShowNubersNatural(n - 1);
    Console.Write($"{n} ");
}

//ShowNubersNatural(5);



//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int GetSumOfDigitsOfNumber(int numb)
{
    if (numb != 0) return GetSumOfDigitsOfNumber(numb/10) + numb % 10;
    else return 0;
}

//Console.WriteLine(GetSumOfDigitsOfNumber(12345));

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void ShowNubersNaturalBetweenTwoNumbers(int firstNumb, int secondNumb)
{
    Console.Write($"{firstNumb} ");
    if (firstNumb > secondNumb) ShowNubersNaturalBetweenTwoNumbers(firstNumb - 1, secondNumb);
    if (firstNumb < secondNumb) ShowNubersNaturalBetweenTwoNumbers(firstNumb + 1, secondNumb);    
}

//ShowNubersNaturalBetweenTwoNumbers(10, 5);

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double MyPow(double numb, int pow)
{
    if (pow > 0) return numb * MyPow(numb, pow - 1);
    if (pow < 0) return (1/numb) * MyPow(numb, pow + 1);
    return 1;
}

Console.WriteLine(MyPow(2, -3));

