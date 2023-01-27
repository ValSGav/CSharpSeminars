/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;

}

void WriteArray(int[] array)

{    int sizeOfArray = array.Length;
    string resultString = "[";
    for (int i = 0; i < sizeOfArray; i++)
    {
        resultString += array[i];
        if (i == sizeOfArray - 1) resultString += "]";
        else resultString += ", ";
    }

    Console.WriteLine(resultString);
}
*/

void WriteArrayOfDouble(double[] array)
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

double[] CreateRandomArrayOfDouble(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }

    return array;
}

/*
int GetCountOfEvenNumbInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0) count ++;
    }

    return count;
}

int GetsumOfOddIndexElements(int[] array)
{
    int sum = 0;
    if (array.Length == 1) return 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       sum = sum + array[i]; 
    }
    return sum;
}
*/

double GetTheDifferenceBwMaxAndMinElementsOfArray(double[] array)
{

    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]> max) max = array[i];
        else if (array[i] < min) min = array[i];
    }

    return max - min;
}


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


/*
Console.Write("Input the size of array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
int[] arrayOfRanomThreeDigitNumbers = CreateRandomArray(sizeOfArray, 100, 999);
WriteArray(arrayOfRanomThreeDigitNumbers;
int countOfEvenNumbers = GetCountOfEvenNumbInArray(arrayOfRanomThreeDigitNumbers);
Console.WriteLine($"Count of even number in array is {countOfEvenNumbers}");
*/


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

/*

Console.Write("Input the size of array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
int[] arrayOfRanomNumbers = CreateRandomArray(sizeOfArray, -1000, 1000);
WriteArray(arrayOfRanomNumbers);

int sumOfOddIndexElements = GetsumOfOddIndexElements(arrayOfRanomNumbers);

Console.WriteLine($"Sum of odd index elements of array: {sumOfOddIndexElements}");
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/



Console.Write("Input the size of array: ");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
double[] arrayOfRanomNumbers = CreateRandomArrayOfDouble(sizeOfArray, -1000, 1000);
WriteArrayOfDouble(arrayOfRanomNumbers);
Console.WriteLine(GetTheDifferenceBwMaxAndMinElementsOfArray(arrayOfRanomNumbers));
