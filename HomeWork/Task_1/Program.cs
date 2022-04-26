//3, 5 -> 243 (3⁵)
//2, 4 -> 16

System.Console.Write( "введите число возводимое в степень - ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write( "Степень - ");
int num2 = Convert.ToInt32(Console.ReadLine());
int result = Convert.ToInt32(Math.Pow(num1,num2));
System.Console.WriteLine(result);