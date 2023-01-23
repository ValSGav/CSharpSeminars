//1.    Напишите программу, которая принимает на вход три числа и проверяет, 
//      может ли существовать треугольник с сторонами такой длины.

bool CheckThreeAngle(int a, int b, int c)
{
    return (a + b > c) && (b + c > a) && (c + a > b);
}


double[] WriteFibb(int arraySize, int a, int b)
{
    double[] arrayFib = new double[arraySize];
    arrayFib[0] = a;
    arrayFib[1] = b;
    for (int i = 2; i < arraySize; i++)
    {
        arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
    }

    return arrayFib;
}

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

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }

    return array;

}

int[] CopyOfMassive(int[] array)
{
    int[] retArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        retArray[i] = array[i];
    }

    return retArray;
}

int[] firstArr = CreateRandomArray(1, 1, 3);
// Console.Write("Input side a: ");
// int sideA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input side b: ");
// int sideB = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input side c: ");
// int sideC = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(CheckThreeAngle(sideA, sideB, sideC));

//2.    Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

Console.Write("Input size of Fibb: ");
int sizeFibb = Convert.ToInt32(Console.ReadLine());


Console.Write("Input numb a: ");
int numbA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input numb b: ");
int numbB = Convert.ToInt32(Console.ReadLine());

double[] arrFib = WriteFibb(sizeFibb, numbA, numbB);

WriteArrayOfDouble(arrFib);

//3.    Напишите программу, которая будет создавать 
//      копию заданного массива с помощью поэлементного копирования.