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




// int[,] newArray = CreateRandomArry2d();
// ShowArray2d(newArray);

/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: Aij = i+j. Выведите полученный массив на экран.
*/

/*

int[,] CreateAndFillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)

            array[i, j] = i + j;
    }

    return array;

}

Console.Write($"Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateAndFillArray(rows, columns);
ShowArray2d(array);

*/

/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
*/
/*
void ChangeBothEvenIndexElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] *= array[i,j]; 
        }
}

int[,] array = CreateRandomArry2d();
ShowArray2d(array);
ChangeBothEvenIndexElements(array);
ShowArray2d(array);

*/

/*
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

double GetSumOfMainDiagonal(int[,] array)
{
    int lastIndex = array.GetLength(0);
    int temp = array.GetLength(1);
    if (temp < lastIndex) lastIndex = temp;

    int sum = 0;

    for (int i = 0; i < lastIndex; i++)
    {
        sum+= array[i,i];
    }
    return sum;
}

int[,] array = CreateRandomArry2d();
ShowArray2d(array);

double sum = GetSumOfMainDiagonal(array);
Console.WriteLine($"Sum of elements on main diagonal is {sum}");


