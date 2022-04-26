// Напишите программу , котрая принимает на вход число N и выдает произведение чисел от 1 до N
//4 -> 24
//5 ->120
//Задача Факториала
int Factorial(int N)
{
    int result = 1;

    for (int i = 1; i <= N; i++)// счетчик
    {
        result = result * i;
    }
    return  result;

}
System.Console.WriteLine(Factorial(4));