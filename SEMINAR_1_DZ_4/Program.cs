// Задача 8: Напишите программу, которая на вход принимает число (N),  
// а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int i=1;
System.Console.WriteLine($"Четные числа в диапазоне от 1 до {N}:");
while (i<=N)
{
if (i%2==0) System.Console.Write($"{i} ");
 i++;  
}
