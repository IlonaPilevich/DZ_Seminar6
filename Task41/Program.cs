// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// 0,7,8,-2,-2 = 2; 1,-7,567,89,223 = 3

int[] array = FillArray(5, -10, 10); 
Console.WriteLine($"Исходный массив чисел: [{String.Join("; ", array)}]");
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}
int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine($"Количество чисел больше нуля: {CountNumber(array)}");