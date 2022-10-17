// Homework 01
// Урок 1. Знакомство с языком программирования С# 

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите первое число  ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число  ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Введите разные числа");
}

else
{
    int max = num1;
    int min = num2;

    if (max < num2) {
        max = num2;
        min = num1;
        }

    Console.WriteLine($"Число {max} больше числа {min}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine ("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2) max = number2;
if (max < number3) max = number3;

Console.WriteLine($"Максимальное число {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = number % 2;

if (remainder == 0)
{
    Console.WriteLine($"Число {number} четное");
}

else
{
    Console.WriteLine($"Число {number} нечетное");
}
*/
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите целое число больше 1");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= number)
{
    int reminder = current % 2;
    if (reminder == 0)
    {
        Console.WriteLine(current + " ");
    }
    current++;
}
*/
