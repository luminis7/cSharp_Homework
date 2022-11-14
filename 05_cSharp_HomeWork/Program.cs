// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}
*/
/*
Console.WriteLine("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, 100, 999);
ShowArray(myArray);
/*
int EvenNumbersCount(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;

    return count;
}

Console.WriteLine($"В указаном выше массиве {EvenNumbersCount(myArray)} четных цифр");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int OddIndexSum(int[] array)
{
    int sum = 0;
    
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}
Console.WriteLine("Сумма элементов на нечетных позициях массива равна " + OddIndexSum(myArray));
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = Math.Round(new Random().NextDouble(), 2);

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) max = array[i];
        if(min > array[i]) min = array[i];
    }
       
    double diff = max - min;
    
    return diff;
}

Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(n);
ShowArray(myArray);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {DiffMaxMin(myArray)}");
