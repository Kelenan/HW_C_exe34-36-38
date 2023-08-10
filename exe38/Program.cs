/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

#region --- 00 ---
Console.Clear();
Console.Title = "Задача 38.";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. array ---

double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble() * 10;
        Console.Write($"{array[i]:F2} ");
    }

#endregion --- 01. array ---

#region --- 02. operations ---


double minValue = array[0];
double maxValue = array[0];
int l = 0;
while (l < array.Length)
{
    if (array[l] < minValue)
        minValue = array[l];
    if (array[l] > maxValue)
        maxValue = array[l];
        l++;
}

double ras = maxValue - minValue;


Console.Write($" ->> Разница между максимальным и минимальным элементов массива: {ras:F2}");


#endregion --- 02. operations ---
