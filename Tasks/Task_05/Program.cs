// Найти произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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
for (int i = 0; i < stop; i++)
{
    int result = array[i] * array[j-1];
    Console.WriteLine($"Произведение {i+1}-го и {j}-го элементов массива равно {result}\t");
    j = j - 1;
}
if (array.Length % 2 > 0)
{
    int result2 = array[stop+1] * array[stop+1];
    Console.WriteLine($"{stop+1} элемент массива не имеет пары");
}