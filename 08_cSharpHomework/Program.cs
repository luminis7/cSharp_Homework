/*

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

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.

/*

void SortArray2dInDecreasing(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if(array[i,j] < array[i,k])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}
SortArray2dInDecreasing(myArray);
Show2dArray(myArray);

*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

/*

int MinSumNumInRows(int[,] array)
{
    int minSumInRow = 0;
    int indexMinSum = 0;
    
    for(int j = 0; j < array.GetLength(1);j++)
        minSumInRow += array[0,j];
    
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sumNumInRow = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumNumInRow += array[i,j];
        }
        if(sumNumInRow<minSumInRow)
        {
            minSumInRow = sumNumInRow;
            indexMinSum = i;
        }
    }
    
    return indexMinSum;
}
Console.WriteLine($"минимальная сумма в строке номер {MinSumNumInRows(myArray)}");

*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*

int[,] nums1 = { { 8,5,6 } , { 7,6,4 } };
int[,] nums2 = { { 1,7,7 } , { 8,3,3 } , { 4,1,7 }};

int[,] ProductMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    if(array1.GetLength(1) == array2.GetLength(0))
    {
            
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = 0;
                for (int x = 0; x < array.GetLength(0); x ++)
                {
                    array[i,j] += array1[i,x] * array2[x,j];
                }   
            }
        }
        return array;
    }
    else 
        return array;
}

int[,] myArray = ProductMatrix(nums1, nums2);

Show2dArray(nums1);
Show2dArray(nums2);
Show2dArray(myArray);

*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// Создан одномерный массив, из которого сформирован трехмерный. Не могу сообразить,
// куда и в какой форме добавить исключение о том, что в массиве не может быть больше 90 элементов.

/*
Console.Write("Input a number of z: ");
int numZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of y: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of x: ");
int numX = Convert.ToInt32(Console.ReadLine());

int arraySize = numX*numY*numZ;

int[] CreateSingleDimensionalArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        for(int j = 0; j < i; j++)
            if (array[i] == array[j]) i--;
    }
    return array;
}

int[] myArray = CreateSingleDimensionalArray(arraySize, 10, 99);

int[,,] CreateRandom3DArray(int z, int y, int x)
{
    int[,,] array = new int[z, y, x];
    int indexMyArray = 0;

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = myArray[indexMyArray];
                indexMyArray++;
            }     
    return array;
}

void Show3DArray(int [,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ( {i} ,{j} ,{k} )" + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] my3DArray = CreateRandom3DArray(numX, numY, numZ);

Show3DArray(my3DArray);

*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Решение дурацкое. И только для квадрата 4 на 4. Сдаю так, не успеваю в официальные сроки. 
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int i = 0;
    int j = 0;

    for(int current = 1; current < array.Length; current++)
    {
        for(; j < array.GetLength(1); j++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = 1, j = array.GetLength(1) - 1; i < array.GetLength(0); i++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = array.GetLength(0) - 1, j = array.GetLength(1) - 2; j >= 0; j--)
        {
            array[i,j] = current;
            current++;
        }
        for(i = array.GetLength(0) - 2, j = 0; i > 0; i--)
        {
            array[i,j] = current;
            current++;
        }
        
        for(i = j = 1; j < array.GetLength(1) -1; j++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = 2, j = array.GetLength(1) -2; i< array.GetLength(0) - 1; i++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = array.GetLength(0) - 2, j = array.GetLength(1) -3; j >= 1; j--)
        {
            array[i,j] = current;
            current++;
        }
    }
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

int[,] myArray = CreateRandom2dArray(4, 4);
Show2dArray(myArray);
*/
