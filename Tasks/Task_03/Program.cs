// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите левую часть диапазона массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите правую часть диапазона массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int [length];
Random random = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++) array[i] = random.Next(min, max);
Console.WriteLine();
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"\nКоличество чисел из диапазона [10, 99] равно {count}");