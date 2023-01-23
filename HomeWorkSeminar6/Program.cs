/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
/*
int GetSumOfPositiveNumbEnteredByTheUser(int countOfNumb)
{
    for (int i = 0; i < countOfNumb; i++)
    {
        Console.Write($"input numb №{i+1}: ");
        if (Convert.ToInt32(Console.ReadLine()) < 0) countOfNumb--;
    }

    return countOfNumb;
}

Console.WriteLine($"Set the number of numbers to be entered: ");
int countOfNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Count of positive numbers is {GetSumOfPositiveNumbEnteredByTheUser(countOfNumb)}");

*/

/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


1. Если к1 = к2 и в1 = в2, то прямые полностью совпадают
2. Если к1 = к2 и в1 != в2, то пересечений нет
3. Точка пересечения х = (к2 - к1)/(в1-в2); у = к1 * (к2 - к1)/(в1-в2) + b1
*/


string GetIntersectionPointOfTwoLines(double k1, double b1, double k2, double b2)
{
    string returnString = "";

    if (k1 == k2 && b1 != b2) returnString = $"There are no intersection points for the straight lines given by the formulas y = {k1}x + {b1} and y = {k2}x + {b2}";
    else if (k1 == k2 && b1 == b2) returnString = $"For the straight lines given by the formulas y = {k1}x + {b1} and y = {k2}x + {b2} all points are intersection points";
    else returnString = 
        $"For the straight lines given by the formulas y = {k1}x + {b1} and y = {k2}x + {b2} the intersection point is ({(k2 - k1)/(b1 - b2)}, {k1 * (k2 - k1)/(b1 - b2) + b1})";
    
    return returnString;
}

Console.WriteLine($"For the straight lines given by the formulas y = k1 * x + b1  and y = k2 * x + b2 set: ");

Console.Write($"k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write($"b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write($"b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetIntersectionPointOfTwoLines(k1, k2, b1, b2));