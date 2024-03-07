// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

Console.Clear();

int[] RandomArray()
{
    int len = new Random().Next(6, 10);
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

int[] ReversArray(int[] arr)
{
    int buff = 0;
    int j = arr.Length - 1;
    for (int i = 0; i <= j / 2; i++)
    {
        buff = arr[i];
        arr[i] = arr[j - i];
        arr[j - i] = buff;
    }
    return arr;
}

void PrintArray(int[] mas)
{
    foreach (var item in mas)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine("");
}

int[] mas = RandomArray();
PrintArray(mas);

mas = ReversArray(mas);
PrintArray(mas);
