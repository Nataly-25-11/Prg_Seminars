// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую  
// день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели (от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write($"Номер дня недели введен неверно - {n}, повторите ввод (от 1 до 7): ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 || n == 7) { System.Console.WriteLine($"День недели с номером {n} - выходной!"); }
else { System.Console.WriteLine($"День недели с номером {n} - рабочий :-("); } 

