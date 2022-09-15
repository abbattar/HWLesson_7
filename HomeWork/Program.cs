# nullable disable
Console.WriteLine("Введите длину (количество строк) массива:");
bool isNumberLines = int.TryParse(Console.ReadLine(), out int lengthLine);
if (!isNumberLines || lengthLine <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}

Console.WriteLine("Введите ширину (количество столбцов) массива:");
bool isNumberRows = int.TryParse(Console.ReadLine(), out int lengthRow);
if (!isNumberRows || lengthRow <= 1)
{
    Console.WriteLine("Неверно!");
    return;
}

int m = lengthLine;
int n = lengthRow;
/*
double[,] arrayDouble = new double[m,n];

void CreateRandomDoubleArray(int m, int n)  // Задача 47
{
    // double[,] doubleArray = new double[m, n]; // если вводить локальную переменную, то метод Print2DDoubleArray выдаёт нули
    Random random = new Random();
    for (int i = 0; i < arrayDouble.GetLength(0); i++) // for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < arrayDouble.GetLength(1); j++) // for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            arrayDouble[i, j] = Convert.ToDouble(random.Next(-50, 50))/10; // doubleArray[i, j] = Convert.ToDouble(random.Next(-50, 50))/10;
        }
    }
}

void Print2DDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine();
    }
}

CreateRandomDoubleArray(m,n);
Print2DDoubleArray(arrayDouble);
*/

int[,] CreateRandomIntArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 30);
        }
    }
    return array;
}

void Print2DIntArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] arrayInt = CreateRandomIntArray(m, n);
Print2DIntArray(arrayInt);
/*
Console.WriteLine("Угадай число из массива:"); // Задача 50
int guessNumber = Convert.ToInt32(Console.ReadLine());
string GuessArrayNumber(int[,] array,int number)
{
    string someString = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                someString = $"{i}, {j}";
            }
            else
            { 
                someString ="Не угадал (=";
            }
        }
    }
    return someString;
}
string guessArrayNumber = GuessArrayNumber(arrayInt, guessNumber);
Console.WriteLine(guessArrayNumber);
*/
// Задача 52
void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} | ");
    }
}

double[] NumberRow(int[,] array)
{
    double[] numberRow = new double[n];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        //numberRow[j] = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            // numberRow[j] = array[0,j];
            numberRow[j] = numberRow[j] + array[i,j];
        }
        numberRow[j] = numberRow[j] / array.GetLength(0);
    }
    return numberRow;
}

/*double[] ConverterIntArray(int[] array)
{
    int[] fromConvert = new int[array.Length];
    double[] toConvert = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        toConvert[i] = fromConvert[i];
    }
    return toConvert;
}
*/

double[] numberRowDouble = NumberRow(arrayInt);
Console.WriteLine();
PrintDoubleArray(numberRowDouble);
// Не получилось