//колличестко цифр в числе, пример 4565 = 4 - 23 = 2.

int Quantity(int number)
{
    int result = 0;
    if(number == 0)
    return 1;
    number = -number;
    while (number !=0)
    {
        number /= 10;
        result++;
    }
return result;
}
System.Console.WriteLine(Quantity(0)); // возврат функции.  

