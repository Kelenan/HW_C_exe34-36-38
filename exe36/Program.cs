/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */


#region --- 00 ---
Console.Clear();
Console.Title = "Задача 36.";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"************************************************************************
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

************************************************************************");
Console.ForegroundColor = curConsoleColor;
#endregion

#region --- 01. array ---

int[] array = GetArray(10, 1, 100);
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
int negativeSum = GetNegativeSum(array);

int GetNegativeSum(int[] arr)
{
    int negativeSum = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 1) negativeSum += el;
    }
    return negativeSum;
}
Console.WriteLine(negativeSum);
#endregion --- 02. operations ---