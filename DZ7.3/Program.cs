// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы

Console.Clear();
int[] mas = {1,2,5,0,10,34};

void PrintArrayRecurse(int len)
{
    Console.Write($"{mas[len]} ");
    if(len > 0) PrintArrayRecurse(len - 1);
}

int len = mas.Length - 1;

Console.Write($"[{string.Join(", ", mas)}] => ");
PrintArrayRecurse(len);

