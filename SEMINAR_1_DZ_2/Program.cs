// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine()); 

Console.Write ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());


if ((a>=b) & (a>=c)) System.Console.WriteLine($"max={a}");
else if ((b>=a) & (b>=c)) System.Console.Write($"max={b}");
    else if ((c>=a) & (c>=b)) System.Console.Write($"max={c}");
