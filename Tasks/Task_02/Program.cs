// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел.

Console.Write("Введите количество элементов массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int [length];
Random random = new Random();
int evenNumbers = 0;
int oddNumbers = 0;

for (int i = 0; i < array.Length; i++) array[i] = random.Next(100, 1000);
for (int j = 0; j < array.Length; j++) Console.Write($"| {array[j]} ");
for (int y = 0; y < array.Length; y++)
{
    if (array[y]%2 == 0) evenNumbers++;
    else oddNumbers++;
}

Console.WriteLine($"\nЧётных элементов: {evenNumbers}");
Console.WriteLine($"Нечётных элементов: {oddNumbers}");