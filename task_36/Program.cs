// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;

}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}    

void Odd(int[] numbers, out int summ)
{
    summ = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(i % 2 != 0)
        {
            summ += numbers[i];
        }
    }
    System.Console.WriteLine($"Сумма нечетных позиций: {summ}");
}


int[] chisla = GetArray(7, -10, 10);
PrintArray(chisla);
Odd(chisla, out int summ);