// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных. 
// Значения элементов массива 0..9

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

void Dictionary(int[,] array)
{
    int a = 0;

    while (a < 10)
    {
        int counter = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (a == array[i, j]) counter++;
            }
        }
        if(counter>0) System.Console.WriteLine($"{a} in this array {counter} times");
        a++;
    }
}

int rows = InputSize("Input rows");
int columns = InputSize("Input columns");
int[,] array = ArrayCreation(rows, columns);
ArrayFill(array);
ArrayPrint(array);
Dictionary(array);
