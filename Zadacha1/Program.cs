// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minRandom, int maxRandom)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minRandom,maxRandom + 1);
    }
    return result;
}

int[] array = GetArray(10,100,999);
Console.WriteLine($"Массив: [ {String.Join(", ", array)} ]");

int Chet = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 ==0) Chet += 1;
}

Console.WriteLine($"Количество чётных чисел в массиве: {Chet} ");
