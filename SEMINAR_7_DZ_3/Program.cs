// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
void PrintArray(double[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}\t");
    }  
    System.Console.WriteLine(); 
}
void PrintArrayMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[] ArithmeticMeanEachColumn(int[,] array)
{
    double sum=0;
    double[] arColum = new double [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum+=array[j,i];
        }  
        arColum[i]=sum/array.GetLength(0);
        sum=0;
    }
    return arColum;
}

int[,] myArray = GenerateArray(3, 3, 0, 10);
PrintArrayMatrix(myArray);
double[] resultArray=ArithmeticMeanEachColumn(myArray);
System.Console.WriteLine("Cреднее арифметическое элементов в каждом "+
"столбце массива:");
PrintArray(resultArray);

