/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4 */

int[] array = GetArray(5, -299, 300);
Console.WriteLine($"[{String.Join(", ", array)}]");

int Countelement = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        Countelement++;
    }
}
Console.WriteLine($"Количество чисел больше нуля -> {Countelement}");


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}