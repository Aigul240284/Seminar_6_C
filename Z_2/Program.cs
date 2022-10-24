//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double b1= 0, k1 = 0, b2 = 0, k2 =0;
InitCoordinatesByUser(ref b1, ref k1, ref b2, ref k2);

double x= (b2-b1)/(k1-k2);
double y = k1 * x + b1;

Console.WriteLine("Точка пересечения двух прямых:");

Console.Write($"x = {x}");
Console.WriteLine();
Console.Write($"y = {y}");


static void InitCoordinatesByUser(ref double b1, ref double k1, ref double b2, ref double k2)
{ 
    try
    {
        Console.Write("Введите b1: ");
        b1 = double.Parse(Console.ReadLine() ?? "");
         Console.Write("Введите k1: ");
        k1 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите b2: ");
        b2 = double.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите k2: ");
        k2 = double.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}


