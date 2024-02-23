// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

// function Create Random Array
int[] CreateRandomArray(int[] mas)
{
    for (int i = 0; i < mas.Length - 1; i++) mas[i] = new Random().Next(1, 99);
    return mas;
}

// function Print Array
void PrintArrayToScreen(int[] mas)
{
    foreach (var item in mas) Console.Write($"{item} ");
    Console.WriteLine();
}

int num = 10;
int[] mas = CreateRandomArray(new int[num]);
PrintArrayToScreen(mas);

int cnt = 0;
for (int i = 0; i < mas.Length; i++)
{
    if(mas[i] >=10 && mas[i]<=90) cnt++;
}
Console.Write($"Count the number in range [10,90] in array: {cnt}");
