
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    //int current = 1;
    int i = 0;
    int j = 0;
    int endRows = array.GetLength(0);
    int endColumns = array.GetLength(1);
    int startColumns = 0;
    int startRows = 0;

    for(int current = 10; current < array.Length; current++)
    {
        for(; j < endColumns; j++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = 0, j = endColumns-1; i < endRows; i++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = endRows-1, j = endColumns -2; j >= startColumns; j--)
        {
            array[i,j] = current;
            current++;
        }
        for(i = endRows-2, j = startColumns; i > startRows; i--)
        {
            array[i,j] = current;
            current++;
        }
    
    
    // ///////////////////////////////////////
        for(i = j = 1; j<columns-1; j++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = 2, j = columns-2; i< rows -1; i++)
        {
            array[i,j] = current;
            current++;
        }
        for(i = endRows-2, j = endColumns -3; j >= startColumns+1; j--)
        {
            array[i,j] = current;
            current++;
        }
        for(i = endRows-3, j = startColumns+1; i > startRows+1; i--)
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

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n);
Show2dArray(myArray);

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



void SortArray2dInDecreasing(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            SortRowInDecreasing(array);
        }
    }
    void SortRowInDecreasing(int[,] array)
    {
        for(int i = 0, j = 0; j < array.GetLength(1)-1; j++)
        {
            if(array[i,j] < array[i,j + 1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i,j + 1];
                    array[i,j + 1] = temp;
                }
        }
        


        
    }
}
SortArray2dInDecreasing(myArray);
Show2dArray(myArray);
*/

/*
Console.Write("Input a number of z: ");
int numZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of y: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of x: ");
int numX = Convert.ToInt32(Console.ReadLine());

int arraySize = numX*numY*numZ;

int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int[] myArray = CreateRandomArray(arraySize, 10, 99);

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

int[,,] myArray2 = CreateRandom3DArray(numX, numY, numZ);

Show3DArray(myArray2);
*/



