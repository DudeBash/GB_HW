//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Задайте коэфецент b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте коэфецент k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте коэфецент b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задайте коэфецент k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = 0;
double y = 0;
if ((k1 == k2)&&(b1==b2))
{
    Console.WriteLine("прямые паралельны");
}
else
{
x = (b2-b1)/(k1-k2);
y = (k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine("Точка пересечения " + x + " " + y );
}
//Написать программу масштабирования фигуры
int side1 = new Random().Next(1,10);
int side2 = new Random().Next(1,10);
int side3 = new Random().Next(1,10);

if ((side1 + side2>side3)&&(side2+side3>side1)&&(side3+side1>side2)){
    Console.WriteLine("сгенерирован треугольник со стронми" );
    Console.WriteLine("строна1: " + side1);
    Console.WriteLine("строна2: " + side2);
    Console.WriteLine("строна3: " + side3);
}
else{
    side1 = new Random().Next(1,10);
    side2 = new Random().Next(1,10);
    side3 = new Random().Next(1,10);
}