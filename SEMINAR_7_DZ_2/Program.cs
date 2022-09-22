// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minRnd, maxRnd + 1);
        }
    }
    return array;
}

void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

(int, bool) FindElement(int[,] array, int line, int column)
{
    if (0<=line&&line<array.GetLength(0)
        &&column>=0&&column<array.GetLength(1))
    {
        return (array[line,column], true);
    }
    else
    {
        return (0, false);
    }
}

int lineNumber = Prompt("Введите номер строки > ");
int columnNumber = Prompt("Введите номер столбца > ");
int[,] myArray = GenerateArray(3, 4, 0, 10);
PrintArrayMatrix(myArray);
(int result, bool yes) =FindElement (myArray,lineNumber,columnNumber);
if (yes)
{
    System.Console.WriteLine($"Элемент массива ({lineNumber},{columnNumber})"+
    $"=> {result}");
}
else
{
System.Console.WriteLine($"В массиве нет элемента с указанными позициями: "+
$"({lineNumber},{columnNumber})");
}