// Задайте одомерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке[10, 99].

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}
void RetNum(int[] Mass, int from, int to)
{
    int count = 0;
    
    for (int i = 0; i < Mass.Length; i++)
    {
        if (Mass[i] >= 10 & Mass[i] <= 99)
        count = count + 1;
         
    }
    return count;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

int start1 = int.Parse(Console.ReadLine()!);
int stop1 = int.Parse(Console.ReadLine()!);

int result = RetNum(mass, start1, stop1);
Console.WriteLine(result);
