/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/



int MyPow(int numb, int powerOf)
{
    int result = numb;
    if (powerOf < 0) return -1;
    else if (powerOf == 0) return 1;

    for (int count = 2; count <= powerOf; count++)
    {
        result *= numb;
    }

    return result;
}

Console.Write("Please, input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.Write("Please, input a pow of number: ");
int pow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MyPow(numb, pow));


/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

*/
/*
int SumOfDigitsInNubers(int numb)
{
    int currentNumb = numb;
    int sum = 0;

    while (currentNumb != 0)
    {
        sum = sum + currentNumb%10;
        currentNumb = currentNumb/10;
    }

    return sum;
}

Console.Write("Please, input a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigitsInNubers(numb));
*/

/*
Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

/*

int[] ReadArray(int sizeOfArray)
{
    int[] newArray = new int[sizeOfArray];
    Console.WriteLine("Please, set elements of array:");
    for (int i = 0; i < sizeOfArray; i++)
    {
        Console.Write($"Set the value of elements with the index {i}: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }

    return newArray;
}

void WriteArray(int[] array)
{
    int sizeOfArray = array.Length;
    string resultString = "[";
    for (int i = 0; i < sizeOfArray; i++)
    {
        resultString += array[i];
        if (i == sizeOfArray - 1) resultString += "]";
        else resultString += ", ";
    }

    Console.WriteLine(resultString);
}

Console.Write("Please, input size of array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
int[] newArray = ReadArray(sizeOfArray);
WriteArray(newArray);
*/