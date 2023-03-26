/* 
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

double [] array;
array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random(). Next (1, 101);
    Console.Write($"{array[i]} ");
}
razn(array);

void razn(double[] massiv)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
    }
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        min = array[i];
    }
    Console.WriteLine($"разница между максимльным и минимальным значением равна {max - min}");
}