// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PositiveNumbers(int num)
{
    int count = 0;
    for(int i = 0; i < num; i++)
    {
        Console.Write("Enter the number: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if(temp > 0)
            count ++;
    }
    return count;
}
Console.Write("How many numbers do you want to enter: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You entered {PositiveNumbers(number)} positive numbers");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
void CrossLinePoint(double b1, double b2, double k1, double k2)
{
    if((k1 -k2) == 0)
        Console.WriteLine("Stright line are parallel");
    if (k2 * b1 == b2 * k1)
        Console.WriteLine("Lines coincide");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Lines intersect at the point X = {x}, Y = {y}");
    }
}

Console.Write("Enter number b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

CrossLinePoint(b1, b2, k1, k2);
*/