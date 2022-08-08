/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
int sum_nechet =0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(0, n);
    if (array[i] % 2 != 0)//условие нечетности
    sum_nechet = sum_nechet + array[i];
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Сумма нечетных чисел равна: " + sum_nechet);