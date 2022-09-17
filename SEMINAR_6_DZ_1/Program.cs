// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr){
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i< arr.Length-1) {System.Console.Write(", ");            
        } else  System.Console.WriteLine("]");
    }   
}

int[] InputArray()
{
    int len = Prompt("Введите длину массива > ");
    var arr = new int[len];
    int count = 0;
    System.Console.WriteLine("Вводите значения элементов");
    for (int i = 0; i < len; i++)
    {
        arr[i] = Prompt(":");
        if (arr[i] < 0) count++;
    }
    return arr;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] arr1=InputArray();
PrintArray (arr1);
int count1=CountPositive(arr1);
System.Console.WriteLine($"Количество чисел больше 0 в заданном массиве: {count1}");
