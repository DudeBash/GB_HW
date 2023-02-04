//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int []arr = new int[100];
int num = 0;
for (int i=0;i!=arr.Length;i++)
{
    arr[i] = new Random().Next(100,999);
    if (arr[i]%2==0)
    {
        num++;
    }
}
Console.WriteLine("Количество четных чисел " + num);
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int []arr2 = new int[100];
int num2 = 0;
for (int i=0;i!=arr.Length;i++)
{
    arr2[i] = new Random().Next(100,999);
    if (i%2!=0)
    {
        num2 = num2 + arr2[i];
    }
}
Console.WriteLine("cумма чисел на нечетных позициях " + num2);
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int []arr3 = {2,4,5,7,10,12,32};
int arr3max = arr3[0];
int arr3min = arr3[0];
for (int i = 0;i!=arr3.Length;i++)
{
    if (arr3[i]>arr37max)
    {
        arr3max=arr3[i];
    }
    else if (arr3[i]<arr3min)
    {
        arr3min=arr3[i];
    }
}
Console.WriteLine( "разница: " + (arr3max-arr3min));