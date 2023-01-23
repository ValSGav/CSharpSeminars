double[,] CreateRandomArry2dOfDouble()
{
    Console.Write($"Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 1);
        }
    }

    return array;
}

void ShowArray2dOfDoule(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandomArry2d()
{

    Console.Write($"Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a min value of array: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a max value of array: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void ShowArray2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArrayOfDouble(double[] array)
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
/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

/*
double[,] array = CreateRandomArry2dOfDouble();
ShowArray2dOfDoule(array);
*/

/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1 7 -> элемента с такими индексами в массиве нет
*/

/*
double GetTheValueOfAnArrayElement(double[,] array, int indexRow, int indexColumn)
{
    if (indexRow > array.GetLength(0) - 1||indexColumn > array.GetLength(1) - 1)
    {
       if (array[0,0] == 0) array[0,0] = 1;
       else array[0,0] = 0;
       return 0;
    }

    return array[indexRow, indexColumn];
}

double[,] array = CreateRandomArry2dOfDouble();
ShowArray2dOfDoule(array);

Console.Write($"Input index of row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input index of column: ");
int column = Convert.ToInt32(Console.ReadLine());

// идея контроля существования элемента массива: 
// запоминаем значение элемента [0,0] и если после выполнения метода он менятся
// элемента с таким индексом не существует, возвращаем значение элемента [0,0] обратно

double valueOfArray_0_0 = array[0,0];
double valueElement = GetTheValueOfAnArrayElement(array, row, column);
if (array[0,0] != valueOfArray_0_0) 
{
    Console.WriteLine($"There is no array element with indexes [{row}, {column}]!");
    array[0,0] = valueOfArray_0_0;
}
else Console.WriteLine($"Value of array element with indexes [{row}, {column}] is {valueElement}");
*/

/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

double[] GetArrayOfAverageColumnsOf2dArray(int[,] array)
{
    double[] returnArray = new double[array.GetLength(1)];
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)

        {
            returnArray[columns] += array[rows, columns];
        }
    returnArray[columns] = returnArray[columns]/array.GetLength(0);    

    }

    return returnArray;
}

int[,] array = CreateRandomArry2d();
ShowArray2d(array);

double[] arrayOfAverage = GetArrayOfAverageColumnsOf2dArray(array);

ShowArrayOfDouble(arrayOfAverage);
