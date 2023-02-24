// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return array;

}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void SummMinMax(double[] numbers)
{
    double minimax = 0;
    double min = numbers[0];
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
        else if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    minimax = max - min;
    System.Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами: {minimax}");
}


double[] spisok = GetArray(10);
PrintArray(spisok);
SummMinMax(spisok);