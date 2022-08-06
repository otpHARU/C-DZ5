// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] result = new double[size];
    Console.Write("Массив: ");
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble() * 100;
        Console.Write("{0}; ", Math.Round(result[i],2));
    }
    return result;
}

double[] array = GetArray(5);

double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
}
double Result = max - min;

Console.WriteLine("\nРазница между элементами = " + Math.Round(Result,2));