// Задача 2: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. 
// В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


int InputSize(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] ArrayCreation(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    return array;
}

void ArrayFill(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] Transponate(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    return array;
}

bool Validate(int rows, int columns)
{
    if (rows == columns) return true;
    else return false;
}

int rows = InputSize("Input rows");
int columns = InputSize("Input columns");
if (Validate(rows, columns))
{
    int[,] array = ArrayCreation(rows, columns);
    ArrayFill(array);
    ArrayPrint(array);
    array = Transponate(array);
    ArrayPrint(array);
}
else System.Console.WriteLine("Error");
