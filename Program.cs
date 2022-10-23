/**************************************************************************************************************
Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
**************************************************************************************************************/

// Console.WriteLine("Введите несколько целых чисел через пробел");
// int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// Console.WriteLine($"В массиве: [{String.Join("|", array)}] {PositiveQuantity(array)} положительных чисел");

int PositiveQuantity(int[] Arr)
{
    int count = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
/**************************************************************************************************************
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
**************************************************************************************************************/
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine()!);

// 1приравниваем правые части данных равенств, потому что они обе равны y:  k1*x+b1=k2*x+b2,  
// выразим отсюда x:
double x = -(b1 - b2) / (k1 - k2);
// Затем подставим полученное значение х в выражение для у:         
double y = k1 * x + b1;

Console.WriteLine($"Ответ: x = {x:f1}; y = {y:f1}");













// Метод заполнения массива:
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}