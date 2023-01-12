/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
*/
/*
int GetMult(int numb)
{
    int mult = 1;

    for (int i = 1; i <= numb; i++)
    {
        mult = mult * i;
    }

    return mult;
}
*/

int GetCountOfNumber(int numb)
{
    int count = 0;
    while (numb > 0)
    {
        count++;
        numb /= 10;
    }
    return count;
}


//Console.Write("Please, input a number: ");
//Console.WriteLine(GetMult(Convert.ToInt32(Console.ReadLine())));

Console.Write("Please, input a number: ");
Console.WriteLine(GetCountOfNumber(Convert.ToInt32(Console.ReadLine())));