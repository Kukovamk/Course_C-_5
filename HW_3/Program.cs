// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();  
}
double MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random z_new = new Random();

    for (int i = 1; i < size; i++)
    arr[i] = Math.Round(z_new.NextDouble() * (from + to) - from, 2);

    return arr;
}
void Diferens(double[] arr)
{
    double z_max = arr[0];
    double z_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (z_max < arr[i])
            z_max = arr[i];
        else if (z_min > arr[i])
        z_min = arr[i];   
    }
    Console.Write($"Max: {z_max}, Min: {z_min}. ");
    Console.WriteLine($"Difference: {z_max} - {z_min}) = {Math.Round(z_max - z_min, 2)}");
}
int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
Diferens(mass);