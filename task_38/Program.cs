// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] FillArrayWithRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(0,40); 
    }
    return array;
}
double[] array = new double [5];
array = FillArrayWithRandom(array);
Console.Write("Ваш случайный массив: ");
Console.WriteLine(string.Join(",  " , array));

double max = 0;
double min = array[0];

for(int i = 0; i < array.Length; i++)
{
      if(array[i] > max)
    {
        max=array[i];
    }
}

for(int i = 0; i < array.Length; i++)
{
    if(array[i] < min)
    {
        min=array[i];
    }
}

double sum = max-min;

System.Console.WriteLine($"Разница между max и min = {sum}");
