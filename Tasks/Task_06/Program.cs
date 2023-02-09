// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите левую часть диапазона массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите правую часть диапазона массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int [length];
Random random = new Random();
int j = array.Length;
int stop = j/2;

for (int i = 0; i < array.Length; i++) array[i] = random.Next(min, max);
Console.WriteLine();
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");
Console.WriteLine();
int difference = array.Max() - array.Min();
Console.WriteLine($"Минимальное значение массива {array.Min()}, максимальное значение массива {array.Max()}");
Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
