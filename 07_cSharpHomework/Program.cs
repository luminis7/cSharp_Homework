
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*

double[,] CreateDouble2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().NextDouble()*(maxValue-minValue) + minValue, 2);
    
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rous: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateDouble2dArray(m, n, min, max);
Show2dArray(myArray);

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
void CheckIndex(int[,] array, int i, int j)
{
    if(i < array.GetLength(0) && j < array.GetLength(1))
        Console.WriteLine(array[i,j]);
    
    else
        Console.WriteLine("There isn't the number with such indexes");
}

Console.Write("Input the first index: ");
int rowInd = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the second index: ");
int columnInd = Convert.ToInt32(Console.ReadLine());

CheckIndex(myArray, rowInd, columnInd);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] AverageColumns(int[,] array)
{
    double[] averageToArray = new double[array.GetLength(1)];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        double tempSum = 0;
        double tempAverage = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            {
                tempSum += array[i,j];
                tempAverage = Math.Round(tempSum / array.GetLength(0), 1);
            }
        averageToArray[j] = tempAverage;
    }
    return averageToArray;
}

void ShowArray(double[] array)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
double[] averageToArray = AverageColumns(myArray);

ShowArray(averageToArray);
