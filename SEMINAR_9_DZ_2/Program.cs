/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNaturalNumbers(int start, int stop)
{
    if (start > stop)
    {
        return 0;
    }
    return start + SumNaturalNumbers(start + 1, stop);
}
int start = Prompt("Введите значение M:");
int stop = Prompt("Введите значение N:");

if (start < 0)
{
    start = 0;
}
if (stop < 0)
{
    stop = 0;
}
if (start > stop)
{
    int temp = start;
    start = stop;
    stop = temp;
}
System.Console.WriteLine($"Cумма натуральных чисел в заданном промежутке:" +
$"равна {SumNaturalNumbers(start, stop)}");
