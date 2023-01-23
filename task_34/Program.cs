// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArrayWithRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000); 
    }
    return array;
}
int[] array = new int [9];
array = FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join("," , array));
int count = 0;

for(int i = 0; i < array.Length; i++)
{
    int A = array[i]%2;
    if(A == 0)
    {
        count+=1;
    }
}
System.Console.WriteLine($"В массиве {count} четное(-ых) значений!");
