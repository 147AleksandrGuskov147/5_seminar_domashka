// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20); 
    }
    return array;
}
int[] array = new int [9];
array = FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join("," , array));
int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    int A = i%2;
    if(A!= 0)
    {
        sum+=array[i];
    }
}
System.Console.WriteLine($"Сумма нечетных значений массива = {sum}");
