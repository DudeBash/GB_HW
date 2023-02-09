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