int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }

    return array;

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

int SumOfNegatinveElementsOfArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }

    return sum;
}

void ChangePositiveToNegativeEelementsOfArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}




/*
Console.Write("Input length of array: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(arrLength, minValue, maxValue);
WriteArray(arr);
Console.WriteLine(SumOfNegatinveElementsOfArray(arr));
*/

//Написать программу, заменяющую положительные элементы массива на отрицательные и наоборот.
/*
Console.Write("Input length of array: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(arrLength, minValue, maxValue);

WriteArray(arr);
ChangePositiveToNegativeEelementsOfArray(arr);
WriteArray(arr);
*/

//Написать программу, определяющую, присутствует ли заданное число в массиве.

bool FindANumberInArray(int numb, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
    }

    return false;
}

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

int CheckTheNuberOfElementsOnTheSegnentAB(int[] arr, int a, int b)
{
    int leftBord = Math.Min(a,b);
    int rightBord = Math.Max(a,b);
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {        
        if(arr[i] >= leftBord && arr[i] <= rightBord)
        {
            count ++;
        }
    }
    
    return count;
}

/*
Console.Write("Input length of array: ");
int arrLength = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateRandomArray(arrLength, minValue, maxValue);

WriteArray(arr);

Console.Write("Input a finding number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if (FindANumberInArray(numb, arr) == true) Console.WriteLine($"Yes! Element equal {numb} in array");
else Console.WriteLine("No!");
*/


//Задача: задать массив из N элементов и определить количество элементов на отрезке от A до B включительно

Console.Write("Input length of array: ");
int arrLength = Convert.ToInt32(Console.ReadLine());

int[] arr = ReadArray(arrLength);
WriteArray(arr);

Console.Write("Enter the number 'A' of segment AB : ");
int numbA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number 'B' of segment AB : ");
int numbB = Convert.ToInt32(Console.ReadLine());



int NumbOfElOnTheSegmentAB = CheckTheNuberOfElementsOnTheSegnentAB(arr, numbA, numbB);

Console.WriteLine($"The number of array elements on the segment AB({numbA}-{numbB}) is {NumbOfElOnTheSegmentAB}");

