// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1*x+b1; y = k2*x+b2

int GetNumberConsole(string message)
{
    int number = 0;
    Console.Write(message);
    string? strValue = Console.ReadLine();
    if (!int.TryParse(strValue, out number))
    {
        Console.WriteLine("Введите числовое значение!");
        Environment.Exit(-1);
    }
    return number;
}

double b1 = GetNumberConsole("Введите значение b1: ");
double k1 = GetNumberConsole("Введите значение k1: ");
double b2 = GetNumberConsole("Введите значение b2: ");
double k2 = GetNumberConsole("Введите значение k2: ");

double x = 0, y = 0;

if ((k1 != k2))
{
    x = (b2 - b1) / (k1 - k2);  // (4 - 2) / (5 - 9) = 2 / -4 = -0.5
    y = k1 * x + b1;            // 5 * -0.5 + b1 = -2.5 + 2 = -0.5
}
else
{
    Console.WriteLine("Решение отсутствует");
}

Console.WriteLine($"Точка пересечения x = {x}; y = {y};");
