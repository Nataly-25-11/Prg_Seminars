// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int len){
    int[] arr = new int[len];
    for(int i = 0; i < len; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr){
    System.Console.Write("Массив: ");
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i< arr.Length-1) {System.Console.Write(", ");            
        } else  System.Console.WriteLine("]");
    }   
}

int EvenNumbers(int[] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if (arr[i]%2==0) count++;
    }
    return count;
}

System.Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArray(N);
PrintArray(array);
System.Console.WriteLine($"Количество четных чисел в массиве: {EvenNumbers(array)}");
