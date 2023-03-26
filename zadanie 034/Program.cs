/* 
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array;
int sum = 0;
array = new int[4];
 for (int i = 0; i < array.Length; i++)
 {
   array[i] = new Random().Next (100, 1000);
    Console.Write($"{array[i]} ");
 }
 Console.WriteLine();
 for (int i = 0; i < array.Length; i++)
 {
  if (array[i] % 2 == 0)
      sum ++;
 }
 Console.WriteLine($"количество четных чисел равна {sum}");