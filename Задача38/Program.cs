/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double x;
for (int i = 0; i < array.Length; i++ )
{
  x = new Random().NextDouble() *100;
  array[i] = Math.Round(x, 2);  
}
double min = array[0];
double max = array[0];
for (int i = 1; i < array.Length; i++ )
{
  if (max < array[i])
  max = array[i];
  if (min > array[i])
  min = array[i];   
}
double raznica = max - min;
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементов массива: " + raznica);