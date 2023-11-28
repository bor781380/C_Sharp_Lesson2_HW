// Задача 3: 
// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
Random rand = new Random();

double elementMax = 0;
double elementMin = 100;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 100) + rand.NextDouble();
    Console.Write(array[i].ToString("F2") + " ");
    if (elementMax<array[i]) elementMax=array[i];
    
    if (elementMin>array[i]) elementMin=array[i];
    
}
Console.WriteLine();
Console.WriteLine("Разница между максимальным и минимальным элементом массива - " + ((elementMax-elementMin).ToString("F2")));