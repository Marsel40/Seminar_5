// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// //  Найдите сумму элементов, стоящих на нечётных позициях.


int[] array = new int[10];

Random rand = new Random();

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
}
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine($" = {sum}");