// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Degree (int x, int st){
    int rezult=x;
    for (int i = 1; i < st; i++)
    {
        rezult=rezult*x;
    }
    return rezult;
}

System.Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Число {A} в степени {B} = {Degree(A,B)}");  

