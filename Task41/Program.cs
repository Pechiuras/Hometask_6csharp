//Task 41
Console.Clear();
Console.Write("Укажите кол-во вводимых чисел: ");
int n = Convert.ToInt32(Console.ReadLine()), count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    int x = Convert.ToInt32(Console.ReadLine());
    if (x > 0)
        count++; // count = count + 1;
}
Console.WriteLine($"Результат: {count}");