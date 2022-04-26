//452 -> 11
//82 -> 10
//9012 -> 12
System.Console.Write("Ввод числа - ");
int N = Convert.ToInt32(Console.ReadLine());
int number1 = N % 10;
int number2 = N %100 / 10;
int number3 = N / 100;
System.Console.WriteLine(number1+number2+number3);