// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenerateArray(int len){
    int[] arr = new int[len];
    for(int i = 0; i < len; i++){
        arr[i] = new Random().Next(1, 100);
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

int SumOddElements(int[] arr){
    int sum = 0;
    for(int i = 1; i < arr.Length; i=i+2){
        sum+=arr[i];
    }
    return sum;
}

System.Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] array = GenerateArray(N);
PrintArray(array);
System.Console.WriteLine($"Сумма нечетных элементов массива: {SumOddElements(array)}");
