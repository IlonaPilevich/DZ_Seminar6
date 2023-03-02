// Напишите программу, которая будет преобразовывать десятичное число в двоичное

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

int number = GetNumberConsole("Введите десятичное числовое значение: ");

string binLine = Convert.ToString(number, 2);
Console.WriteLine($"Бинарный формат числа {number} = {binLine}");
