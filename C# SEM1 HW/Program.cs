//Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("введите номер дня недели");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1 == 6|number1 == 7 )
{
    Console.WriteLine("этот день является выходным");
}
else
{
    Console.WriteLine("этот день не является выходным");
}

//По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("введите первое ,а замтем второе число, для проверки является ли одно из них квадратом другого");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

if (Math.Pow(number2,2) == number3)
{
    Console.WriteLine("Второе число является квадаратом первого чилса");
}
else if (Math.Pow(number3,2)==number2)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}

//Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("введите номер четверти (от 1 до 4)");
int number4 = Convert.ToInt32(Console.ReadLine());
if (number4 == 1)
{
    Console.WriteLine("диапозон для первой четверти X>0 Y>0");
}
if (number4 == 2)
{
    Console.WriteLine("диапозон для второй четверти X<0 Y>0");
}
if (number4 == 3)
{
    Console.WriteLine("диапозон для первой четверти X<0 Y<0");
}
if (number4 == 4)
{
    Console.WriteLine("диапозон для первой четверти X>0 Y<0");
}
else
{
    Console.WriteLine("число не входит в диапозон от 1 до 4");
}

//Найти расстояние между точками в пространстве 2D/3D

double x1 = 0;
Console.WriteLine("введите число x1");
x1 = Convert.ToDouble(Console.ReadLine());

double y1 = 0;
Console.WriteLine("Введите число y1");
y1 = Convert.ToDouble(Console.ReadLine());

double x2 = 0;
Console.WriteLine("Введите число x2");
x2 = Convert.ToDouble(Console.ReadLine());

double z1 = 0;
Console.WriteLine("Ввдите координату z2");
z1 = Convert.ToDouble(Console.ReadLine());

double y2 = 0;
Console.WriteLine("Ввдите координату y2");
y2 = Convert.ToDouble(Console.ReadLine());

double z2 = 0;
Console.WriteLine("Ввдите координату z2");
z2 = Convert.ToDouble(Console.ReadLine());
double distance = 0;

distance = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
Console.WriteLine("Дистанция между точками" + distance);