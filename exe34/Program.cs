/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

#region --- 00 ---
Console.Clear();
Console.Title = "Задача 34.";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте массив заполненный случайными положительными трёхзначными числами.
    Напишите программу, которая покажет количество чётных чисел в массиве.

************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. array ---

int[] array = GetArray(7, 100, 1000);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
#endregion --- 01. array ---

#region --- 02. operations ---
int positive = GetPositive(array);

int GetPositive(int[] arr)
{
    int positive = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) positive += 1;
    }
    return positive;
}
Console.WriteLine(positive);
#endregion --- 02. operations ---