// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// k1 = 5, b1 = 2, k2 = 9, b2 = 4 -> (-0,5; -0,5)
// k1 = 1, b1 = 1, k2 = 1, b2 = 1 -> Прямые совпадают
// k1 = 3, b1 = 2, k2 = 3, b2 = 5 -> Прямые параллельны
double Prompt(string message)
{
    System.Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

string InterPoints(double k1,double b1,double k2,double b2, out double x, out double y)
{
    x=y=0;
    if ((k1 == k2) && (b1 == b2)) return("Прямые совпадают");
    else
    {
        if (k1 == k2) return("Прямые параллельны");
        else
        {
            x = (b2 - b1) / (k1 - k2);
            y = k1 * (b2 - b1) / (k1 - k2) + b1;            
        }
    }
    return null;
}

double k1=Prompt("Введите коэффициент k1 первой прямой ->");
double b1=Prompt("Введите коэффициент b1 первой прямой ->");
double k2=Prompt("Введите коэффициент k1 второй прямой ->");
double b2=Prompt("Введите коэффициент b1 второй прямой ->");
double x, y;
var msg=InterPoints(k1,b1,k2,b2,out x,out y);
if (msg==null) System.Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x},{y})");
else System.Console.WriteLine(msg);
