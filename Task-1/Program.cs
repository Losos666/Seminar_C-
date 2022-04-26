int SumToA(int A)
{
    int result = 0;

    for (int i = 1;i <= A;i++) // от 0 до числа A
{
    //result = result + i;// сохраннение чисел до А
    result += i;
}

return result;
}
//int sum1;
//sum1 = SumToA(4);
//System.Console.WriteLine(sum1);
//все что выше можно заменить 
System.Console.WriteLine("Сумма ровна" + SumToA(4));
