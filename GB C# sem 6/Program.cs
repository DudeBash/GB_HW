//Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("введите количество столбцов");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("введите высоту столбцов");
int y = int.Parse(Console.ReadLine());
int [,] arr = new int [x,y];

void fillArr (int [,] arr)
{
    for (int fill_x=0; fill_x < arr.GetLength(0); fill_x++)
    {
       for (int fill_y=0; fill_y < arr.GetLength(1);fill_y++)
       {
         arr[fill_x,fill_y] = new Random().Next(1,999);
       }
       
    }
    
}


void OutputArr (int [,] arr)
{
    for (int fill_x=0; fill_x < arr.GetLength(0); fill_x++)
    {
       for (int fill_y=0; fill_y < arr.GetLength(1);fill_y++)
       {
         Console.WriteLine(arr[fill_x,fill_y]);
       }
       
    }
    
}

//Задать двумерный массив следующим правилом: Aₘₙ = m+n (не смог понять что нужно сделать)

//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
for (int fill_x = 0; fill_x < arr.GetLength(0);fill_x++)
{
    for (int fill_y = 0; fill_y < arr.GetLength(1);fill_y++)
    {
        if (((fill_y%2)==0)&&((fill_x%2)==0))
        {
            arr [fill_x,fill_y] = arr [fill_x,fill_y]*arr [fill_x,fill_y];
        }
    }
}
fillArr(arr);
OutputArr(arr);
int sum = 0;
//В матрице чисел найти сумму элементов главной диагонали
for (int fill_x = 0; fill_x < arr.GetLength(0);fill_x++)
{
    for (int fill_y = 0; fill_y < arr.GetLength(1);fill_y++)
    {
        if (((fill_y%2)==0)&&((fill_x%2)==0))
        {
            if (fill_x == fill_y)
            {
                sum += arr[fill_x,fill_y];
            }
        }
    }
}

Console.WriteLine("сумму элементов главной диагонали " + sum );

