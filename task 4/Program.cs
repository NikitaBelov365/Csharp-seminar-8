// Задача 4: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


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
            array[i, j] = new Random().Next(0, 10);
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

(int, int) SearchMin(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }
    return (minRow, minColumn);
}

int[,] DeletingMin(int[,] array, int minRow, int minColumn)
{
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == minRow || j == minColumn) continue;
            int k = i;
            int l = j;
            if(i>minRow) k--;
            if(j>minColumn) l--;
            newArray[k, l] = array[i, j];
        }
    }
    return newArray;
}

int rows = InputSize("Input rows");
int columns = InputSize("Input columns");
int[,] array = ArrayCreation(rows, columns);
ArrayFill(array);
ArrayPrint(array);
(int row, int column) = SearchMin(array);
int[,] newArray = DeletingMin(array, row, column);
ArrayPrint(newArray);