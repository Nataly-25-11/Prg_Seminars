// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10 
// 9012 -> 12
int SumNum (int x){
int sum = 0;
int i = 1;
int z = x;
    while (z > 0)
    {
        sum=sum + x /Convert.ToInt32(Math.Pow(10,i-1))%10;
        z/=10;
        i=i+1;
    }
return sum;
}
System.Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {A} равна {SumNum(A)}");
