// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
bool CheckPalindrome(int number) 
{
    int original = number;
    int reversed = 0;
    int current;
    while(number > 0)
    {
        current = number % 10;
        reversed = reversed*10 + current;
        number = number /10;
    }
    return (reversed == original);
}

Console.Write("Enter a natural number: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());

if(CheckPalindrome(naturalNumber) == true)
Console.WriteLine($"number {naturalNumber} is a palindrome");
else Console.WriteLine($"number {naturalNumber} is not a palindrome");
*/

// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Distance(double ax, double ay, double az, double bx, double by, double bz)
{
    double lineX = ax - bx;
    double lineY = ay - by;
    double lineZ = az - bz;
    double distance = Math.Sqrt(Math.Pow(lineX, 2) + Math.Pow(lineY, 2) + Math.Pow(lineZ, 2));
    return Math.Round(distance, 2);
}
Console.WriteLine("Введите точку ax: ");
int ax = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку ay: ");
int ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку az: ");
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку bx: ");
int bx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку by: ");
int by = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите точку bz: ");
int bz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние между точками равно {Distance(ax, ay, az, bx,by, bz)}");
*/
// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void Cube(int n)
{
    int index = 1;
    while (index <= n)
    {
        double result = Math.Pow(index, 3);
        Console.Write(result + " ");
        index++;
    }
}

Console.WriteLine("Введите число больше или равно 1: ");
int temp = Convert.ToInt32(Console.ReadLine());

Cube(temp);
*/