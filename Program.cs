// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int getUserData(string massage)
{
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

double CrossPointX(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
double CrossPointY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

double k1 = getUserData("Введите значение точки К1");
double b1 = getUserData("Введите значение точки В1");
double k2 = getUserData("Введите значение точки К2");
double b2 = getUserData("Введите значение точки В2");
double X = CrossPointX(k1, b1, k2, b2);
double Y = CrossPointY(k1, b1, X);
Console.WriteLine($"Точка пересечения двух прямых [{X} , {Y}] ");


