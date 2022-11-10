// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*

int Exponent (int a, int b)
{
    int current = a;
    if(b == 0)
        current = 1;

    for(int count = 1; count < Math.Abs(b); count++)
        current *= a;

    return current;
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {num1} в {Math.Abs(num2)} степени равно {Exponent(num1, num2)}");
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
int SumDigit(int number)
{
    int sum = 0;
    number = Math.Abs(number);
    
    while(number > 0)
    {
        int lastDigit = number % 10;
        sum += lastDigit;
        number /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int temp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {temp} равна {SumDigit(temp)}");
*/

// Задача 29: Напишите программу, которая задаёт массив из m элементов, введденных пользователем, и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine(" /n ");
}

Console.WriteLine("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m);
ShowArray(myArray);