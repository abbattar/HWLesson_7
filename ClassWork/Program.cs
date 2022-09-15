// Задача 46 задать массив размером m x n, заполненный случайными числами

Console.WriteLine("Введите длину (количество столбцов) массива:");
bool isNumberLines = int.TryParse(Console.ReadLine(), out int lengthLine);
if (!isNumberLines || lengthLine <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}

Console.WriteLine("Введите ширину (количество строк) массива:");
bool isNumberRows = int.TryParse(Console.ReadLine(), out int lengthRow);
if (!isNumberRows || lengthRow <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}

Console.WriteLine();

int m = lengthRow;
int n = lengthLine;

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] result = CreateRandomArray(m, n);
Print2DArray(result);

int[,] MPlusNArray(int m, int n)
{
    int[,] arrayMPlusN = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arrayMPlusN[i, j] = i + j;
        }
    }
    return arrayMPlusN;
}

Console.WriteLine();
int[,] resultMN = MPlusNArray(m, n);
Print2DArray(resultMN);

int[,] SquaredEvenArray(int[,] result)
{
    int[,] squaredEvenArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                squaredEvenArray[i, j] = result[i, j] * result[i, j];
            }
            else
            {
                squaredEvenArray[i, j] = result[i, j];
            }
        }
    }
    return squaredEvenArray;
}

Console.WriteLine();
int[,] resultSquaredArray = SquaredEvenArray(result);
Print2DArray(resultSquaredArray);

int min = 0;
if (m >= n) min = n;
if (m < n) min = m;

int SumOfElementsOnMainDiag(int[] array)
{
    int sumOfElementsOnMainDiag = 0;
    for (int i = 0; i < min; i++)
    {
        sumOfElementsOnMainDiag = sumOfElementsOnMainDiag + array[i];
    }
    return sumOfElementsOnMainDiag;
}

int[] TableOfElementsOnMainDiag(int[,] array)
{
    int[] tableOfElementsOnMainDiag = new int[min];
    for (int i = 0; i < min; i++)
    {
        tableOfElementsOnMainDiag[i] = array[i, i]++;
    }
    return tableOfElementsOnMainDiag;
}

void PrintArray(int[] array)
{
    // if (array.Length == 0)
    // {
    //     Console.WriteLine("Что то пошло не так!");
    //     return;
    // }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    } 
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

Console.WriteLine();
int[] diagElements = TableOfElementsOnMainDiag(result);
Console.Write("Элементы главной диагонали: ");
PrintArray(array: diagElements);
Console.WriteLine();
int resultSum = SumOfElementsOnMainDiag(diagElements);
Console.WriteLine($"Сумма элементов главной диагонали равно: {resultSum}");
Console.WriteLine();