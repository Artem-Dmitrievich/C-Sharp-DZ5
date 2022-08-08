/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
int count = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100, 1000);//100 включает, 1000 не включает(=999)
    if (array[i] % 2 == 0)//условие четности
    count++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Количество четных чисел:" + count);