// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76


double[] GenerateArray(int len){
    double[] arr = new double[len];
    var random=new Random();
    for(int i = 0; i < len; i++){
        arr[i] = random.NextDouble();
    }
    return arr;
}


void PrintArray(double[] arr){
    System.Console.Write("Массив: ");
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i< arr.Length-1) {System.Console.Write(", ");            
        } else  System.Console.WriteLine("]");
    }   
}

double DifMinMax(double[] arr){
  double min=double.MaxValue;
  double max=double.MinValue;
  double dif;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i]<min) min=arr[i];
    if (arr[i]>max) max=arr[i];
  }
dif=max-min;
return dif;
}

System.Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] array = GenerateArray(N);
PrintArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {DifMinMax(array)}");
