// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.Write ("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int a3=(a%1000-a%100)/100;
if (a<100) {System.Console.WriteLine("Третьeй цифры нет.");}
else {System.Console.WriteLine($"Третья цифра: {a3}");} 
