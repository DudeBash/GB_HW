
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
int j = 1;
int sum = 0;
Console.WriteLine("Введите первых два числа последовательности");
int A = int.Parse(Console.ReadLine() ?? "");
int B = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите количество чисел, которое нужно отобразить");
int numb = int.Parse(Console.ReadLine() ?? "");
int step = B - A;
int temp = 0;
//Показать натуральные числа от 1 до N, N задано
int ExOne(int N, int j){
    if (j<N) 
    {
        Console.WriteLine("ex1: " + j); return (j) + ExOne(N,j+1);
    }
    else Console.WriteLine("ex1: " + j); return 0;
}
ExOne(N,j);
//Показать натуральные числа от N до 1, N задано
int ExTwo(int N, int j){
    if (N>j) 
    {
        Console.WriteLine("ex2: " + N); return (N) + ExTwo(N-1,j);
    }
    else Console.WriteLine("ex2: " + j); return 0;
}
ExTwo(N,j);
// Показать натуральные числа от M до N, N и M заданы
int ExThree(int N, int M){
    if (M<N) 
    {
        Console.WriteLine("ex3: " + M); return (M) + ExThree(N,M+1);
    }
    else return 0;
}
ExThree(N,M);
//Найти сумму элементов от M до N, N и M заданы
int ExFour(int N, int sum, int M){
    if (M<N)
    {
        return ExFour(N,sum+=M,M+1);
    }
    else Console.WriteLine("ex4: " + sum); return 0;
}
ExFour(N,sum,M);
//Найти сумму цифр числа
int ExFive(int sum,int N){
    if (N>0)
    {
        return ExFive(sum+=N%10,N/10);
    }
    else Console.WriteLine("Ex5: " + sum); return 0;
}
ExFive(sum,N);
//Написать программу вычисления функции Аккермана
 int ExSix(int N, int M){
    if (N == 0) 
    {
        return M + 1;
    }
    if (N != 0 && M == 0) 
    {
        return ExSix(N - 1, 1);
    }
    if (N > 0 && M > 0) 
    {
        return ExSix(N - 1, ExSix(N, M - 1));
    }

    else Console.WriteLine(ExSix(N,M));return ExSix(N,M);
}
ExSix(N,M);
//Написать программу возведения числа А в целую стень B
int ExSeven(int sum,int N,int M,int j){
    if(j < M)
    {
        return (j) + ExSeven(sum=sum*N,N,M,j+1);
    }
    else Console.WriteLine("ex7: " + sum); return 0;
}
sum=N;
ExSeven(sum,N,M,j);
//Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
string ExEight(int A, int numb)
{
    if (temp < numb)
    {
        temp++;
        return $"{A} " + ExEight(A + step, numb);
    }
    else return String.Empty;
}

Console.WriteLine("ex8: " + ExEight(A, numb));