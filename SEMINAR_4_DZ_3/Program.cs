// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] GetArray(){
    int[] result = new int[8];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}
void PrintArray(int[] arr){
    System.Console.WriteLine("Массив:");
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i< arr.Length-1) {System.Console.Write(", ");            
        } else  System.Console.WriteLine("]");
    }   
}

PrintArray(GetArray());
