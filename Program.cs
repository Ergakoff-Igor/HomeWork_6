/**************************************************************************************************************
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
**************************************************************************************************************/

Console.WriteLine("Введите несколько целых чисел через пробел");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine($"В массиве: [{String.Join("|", array)}] {PositiveQuantity(array)} положительных чисел");

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