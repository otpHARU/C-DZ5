// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minRandom, int maxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minRandom,maxRandom + 1);
    }
    return result;
}

int[] array = GetArray(5,0,100);
Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");

int sum = 0;

for (int i = 0; i < array.Length; i+=2)
{
    sum += array[i];
}

Console.WriteLine($"Сумма элементов на нечётных позициях = {sum} ");


