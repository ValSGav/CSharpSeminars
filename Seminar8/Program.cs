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


/*
Задайте двумерный массив. Напишите программу, которая 
 местами первую и последнюю строку массива.
*/

void ChangeTwoRowsOfArray(int[,] array, int rowOne, int rowTwo)
{
    if (rowOne >= 0 && rowTwo >= 0 &&
        rowOne <= array.GetLength(0) &&
        rowTwo <= array.GetLength(0))

        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[rowOne, j];
            array[rowOne, j] = array[rowTwo, j];
            array[rowTwo, j] = temp;
        }
}

/*
int[,] array = CreateRandomArry2d();
ShowArray2d(array);

Console.Write("Input row one: ");
int r1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input row two: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeTwoRowsOfArray(array, r1, r2);

ShowArray2d(array);
*/

/*
Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы.
1   4   7   9
9   8   6   4  
2   0   8   9
5   6   7   9
*/

void ChangeRowsAnsColumnsOfArray(int[,] array)
{

    if (array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (j > i)
                {
                    int temp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = temp;
                }
            }
        }
}

// int[,] array = CreateRandomArry2d();
// ShowArray2d(array);
// ChangeRowsAnsColumnsOfArray(array);
// ShowArray2d(array);
int[] FindIndexesOfMinValueOfArray(int[,] array)
{
    int minValue = array[0,0];
    int columnOfMinValue = 0;
    int rowOfMinValue = 0;
    // найдем индексы минимального элемента массива
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i,j] < minValue)
            {
                columnOfMinValue = i;
                rowOfMinValue = j;
                minValue = array[i,j];
            } 
        }
    }

    return new int[] {columnOfMinValue, rowOfMinValue};
}

int[,] DeleteRowAndColumnWithMinValueOnIntersection(int [,] array, int[] arrayOfIndexesOfMinValue)
{
    
    int columnOfMinValue = arrayOfIndexesOfMinValue[0];
    int rowOfMinValue = arrayOfIndexesOfMinValue[1];

    int[,] returnArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];

    int currCol = 0;
    int currRow = 0;

    for (int i = 0;  i < returnArray.GetLength(0); i++)
    {
        if (i>= columnOfMinValue) currCol = i+1;
        else currCol = i ;

        for (int j = 0; j < returnArray.GetLength(1); j++)
        {
            if (j>= rowOfMinValue) currRow = j+1;
            else currRow = j ;

            returnArray[i,j] = array[currCol, currRow];   
        }
    }

    return returnArray;
}

/*
Из двумерного массива целых чисел удалить строку и столбец, 
на пересечении которых расположен наименьший элемент.
*/

int[,] array = CreateRandomArry2d();
ShowArray2d(array);
int[,] newArray = DeleteRowAndColumnWithMinValueOnIntersection(array, FindIndexesOfMinValueOfArray(array));
ShowArray2d(newArray);