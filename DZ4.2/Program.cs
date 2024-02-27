// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [344 452 341 125] => 2
Console.Clear();

int[] RandomArray()
{
    int len = new Random().Next(4, 10);
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] mas)
{
    foreach (var item in mas)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("");
}

int SumEven(int[] array)
{
    int sum = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) sum++;
    }
    return sum;
}

int[] array = RandomArray();
PrintArray(array);
Console.Write("Количество четных элементов в массиве = " + SumEven(array));

