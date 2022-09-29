/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
void ShowNumbers(int number)
{
    if (number <= 0)
    {
        return;
    }
    System.Console.Write($" {number}");
    ShowNumbers(number - 1);
}
int number = Prompt("Введите число N:");
if (number <= 0)
{
    number = 1;
}
System.Console.WriteLine($"Натуральные числа в промежутке от заданного N до 1:");
ShowNumbers(number);
