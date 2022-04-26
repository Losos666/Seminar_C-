int max (int a,int b)
{
    if (a > b)
        return a;
    else
        return b;
}
System.Console.WriteLine(max(-1,2));//возвращает значение

void PrintMax(int a, int b)
{
      if (a > b)
        System.Console.WriteLine(a);
    else
       System.Console.WriteLine(b);
}
PrintMax(10,15);