// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Num2(int number)
{
    int firstNum = number / 10;
    int secondNum = firstNum % 10;
    return secondNum;
}

Console.Write("Введите трехзначное число:  ");
int temp = Convert.ToInt32(Console.ReadLine());

int result = Num2(temp);

Console.WriteLine($"Вторая цифра числа {temp} это {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdthNum(int number)
{
    number  = Math.Abs(number);

    if(number > 99)
    {
        while(number > 999)
        {
            number = number / 10;
        }
        number = number % 10;
        return (number); 
    }
    else
    {
        number = -1;
        return number;
    }
  
}

Console.Write("Введите число: ");
int temp = Convert.ToInt32(Console.ReadLine());
int result = ThirdthNum(temp);

if(result == -1)
    Console.WriteLine($"Третья цифра отсутствует");
else
    Console.WriteLine($"Третья цифра числа {temp} это {result}");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

