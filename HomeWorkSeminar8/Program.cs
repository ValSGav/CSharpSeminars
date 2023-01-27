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

int[,] CreateVoidArry2d()
{
    Console.Write($"Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

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

void Show3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        Console.WriteLine($"Layer {i}:");
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write(array[j, k, i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/





/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] MultiplicationOfTwoMatrix(int[,] array1, int[,] array2)
{
    
}


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/**************************************************************************************************
int[,,] CreateRandom3DArrayOfNonRepeatingNumber(int columns, int rows, int layers, int countOfTheDigitsInTheNumber)
{
    int minNumber = Convert.ToInt32(Math.Pow(Convert.ToDouble(10), Convert.ToDouble(countOfTheDigitsInTheNumber - 1)));
    int maxNumber = minNumber * 10 - 1;

    //Console.WriteLine($"Filling range: min number is {minNumber}, max number is {maxNumber}");

    int[,,] returnArray = new int[rows, columns, layers];

    if (columns * rows * layers <= maxNumber)
    {
        bool[] usedNumbers = new bool[maxNumber+1];
        Random randomizer = new Random();

        double numberOfIterations = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int f = 0; f < layers; f++)
                {
                    int newNumber = randomizer.Next(minNumber, maxNumber + 1);
                    numberOfIterations++;
                    while (usedNumbers[newNumber])
                    {
                        newNumber = randomizer.Next(minNumber, maxNumber + 1);
                        numberOfIterations++;
                    }
                    usedNumbers[newNumber] = true;
                    returnArray[i, j, f] = newNumber;
                }
            }
        }

        Console.WriteLine($"Number of iteration is {numberOfIterations}");
        return returnArray;
    }
    return returnArray;

}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of layers: ");
int layers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of digits in the nubers with which we will fill the array: ");
int countOfTheDigits = Convert.ToInt32(Console.ReadLine());

int[,,] array3D = CreateRandom3DArrayOfNonRepeatingNumber(columns, rows, layers, countOfTheDigits);
Show3DArray(array3D);
**************************************************************************************************/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/**************************************************************************************************
void FillArraySpirally(int[,] array, int[,] variantsOfDirections, int fillValue = 1, int direction = 0, int col = 0, int row = 0, bool directionChanged = false)
{

    array[col, row] = fillValue; //заполняем текущий элемент массива текущим значением

    // вычисляем строку и столбец следующего элемента массива, который
    // будем заполнять в соответствии со значениями приращения по строкам и столбцам
    int nextCol = col + variantsOfDirections[direction, 0];
    int nextRow = row + variantsOfDirections[direction, 1];

    if (nextCol >= 0 &&
        nextRow >= 0 &&
        nextCol < array.GetLength(0) &&
        nextRow < array.GetLength(1) &&
        array[nextCol, nextRow] == 0) //проверяем, что не вышли за пределы массива и, что следующий элемент массива не заполнен
    {
        fillValue++;
        directionChanged = false; //признак того, что на предыдущем шаге изменяли направление движения по массиву
        FillArraySpirally(array, variantsOfDirections, fillValue, direction, nextCol, nextRow, directionChanged);
    }
    else
    {
        if (directionChanged != true)   //если на предыдущем шаге уже меняли направление движения, 
                                        //значит достигли конечной точки в спирали заполнения, если нет, меняем направление движения
        {
            direction += 1;
            if (direction > 3) direction  = 0;
            directionChanged = true;
            FillArraySpirally(array, variantsOfDirections, fillValue, direction, col, row, directionChanged);

        }
    };
}

int[,] variantsOfDirections = new int[,]{{0,1}, {1,0}, {0,-1}, {-1,0}}; 
int[,] array = CreateVoidArry2d();
FillArraySpirally(array, variantsOfDirections);
//FillArraySpirally(array, variantsOfDirections,100);
ShowArray2d(array);
**************************************************************************************************/