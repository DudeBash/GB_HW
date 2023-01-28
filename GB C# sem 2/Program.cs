//Вывесьт таблицу квадратов от 1 до N
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

for (int i=1;i<=N;i+=1)
{
    Console.WriteLine(i +": "+ i*i);
}
//Найти сумму чисел от 1 до А
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i=1;i<=A;i+=1)
{
    sum = sum + i;
    Console.WriteLine(i+": "+sum);
}
//Возведите число А в натуральную степень B используя цикл
Console.WriteLine("введите число ,а затем степенень возведения");
int NumA = Convert.ToInt32(Console.ReadLine());
int NumB = Convert.ToInt32(Console.ReadLine());
int mnoj = NumA;
for (int i = 1; i<NumB;i+=1)
{
    NumA = NumA*mnoj;
}
Console.WriteLine(NumA);
// вывести сумму цифр числа
Console.Write("Введите число чтобы вывести сумму цифр числа");
int num = Convert.ToInt32(Console.ReadLine());
int csum = 0;
for (int i = 1;num>0;i+=1)
{
    csum = csum + num%10;
    num/=10;
}
Console.WriteLine("Сумма цифр введенного числа" + " " + csum);
//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число для вычисления произведения чисел от 1 до N ");
int NumN = Convert.ToInt32(Console.ReadLine());
int sum2 = 1;
for (int i=1;i<=NumN;i+=1)
{
    sum2 = NumN * i;
    Console.WriteLine(i+": "+sum2);
}
//Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("ввдите число чтобы Показать куб числа, заканчивающиеся на четную цифру");
int NumN2 = Convert.ToInt32(Console.ReadLine());
if ((NumN2%10)%2==0)
{
    Console.WriteLine(Math.Pow(NumN2,3));
}
else
{
    Console.WriteLine("Число заканчивается на нечетную цифру");
}
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] arr = {0,1,0,1,0,1,0,1};
for (int i=0;i != 7;i+=1)
{
    Console.WriteLine(arr[i]);
}
//Определить, присутствует ли в заданном массиве, некоторое число
int[] arr2 = {0,2,3,5,7,1,13,12};
Console.WriteLine("введите число, чтобы проверить его наличие в массиве");
int check = Convert.ToInt32(Console.ReadLine());
for (int i=0;i != 7;i+=1)

{
    if (arr2[i]==check)
    {
        Console.WriteLine("заданое число есть в массиве под индексом" + " " + i);
    }
    
}
//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] arr3 = {993,222,332,534,788,233,139,125};
int CountEven = 0;
int CountUnEven = 0;
for (int i=0;i != 7;i+=1)

{
    if (arr3[i]%2==0)
    {
        CountEven+=1;
    }
    else
    {
        CountUnEven+=1;
    }
}
Console.WriteLine("Количество четных " + CountEven + " Количество не четных " + CountUnEven);
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr4 = new int [123];
int CountArr4 = 0;
for (int i = 0;i!=arr4.Length; i++)
{
    arr4[i] = new Random().Next(-50,200);
    Console.WriteLine(arr4[i]);

    if (arr4[i]>=10 & arr4[i]<=99)
    {
        CountArr4++;
    }
}

Console.WriteLine("количество элементов равных от 10 до 99] "+ CountArr4);
//Найти сумму чисел одномерного массива стоящих на нечетной позиции
int []arr5 = new int [100];
int SumArr5 = 0;
for (int i = 0;i!=arr5.Length; i++)
{
    arr5[i] = new Random().Next(-50,200);
    Console.WriteLine(arr5[i]);

    if (i%2!=0)
    {
        SumArr5+=arr5[i];
    }
}
Console.WriteLine("сумма чисел одномерного массива стоящих на нечетной позиции " + SumArr5);
//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int []arr6 = new int [100];
int last = arr6.Length-1;
for (int i = 0;i!=arr6.Length; i++)
{
    arr6[i] = new Random().Next(-50,200);
}
for (int i = 0;i!=arr6.Length; i++)
{
    Console.WriteLine("пара №" + i + " :" + arr6[i]*arr6[last]);
    last--;
}
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int []arr7 = {2,4,5,7,10,12,32};
int arr7max = arr7[0];
int arr7min = arr7[0];
for (int i = 0;i!=arr7.Length;i++)
{
    if (arr7[i]>arr7max)
    {
        arr7max=arr7[i];
    }
    else if (arr7[i]<arr7min)
    {
        arr7min=arr7[i];
    }
}
Console.WriteLine( "разница: " + (arr7max-arr7min));