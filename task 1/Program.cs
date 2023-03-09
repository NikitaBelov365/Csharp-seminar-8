// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.

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
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] ArrayChange(int[,] array)
{
    int lastRow = array.GetLength(0)-1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        (array[lastRow, i], array[0, i]) = (array[0, i], array[lastRow, i]);
    }
    return array;
}

int rows = InputSize("Input rows");
int columns = InputSize("Input columns");
int[,] array = ArrayCreation(rows, columns);
ArrayFill(array);
ArrayPrint(array);
array = ArrayChange(array);
ArrayPrint(array);
