
System.Console.Write("введите колличество элементов массива : ");
int elementCount = int.Parse(Console.ReadLine());

int[] myArray = new int [elementCount];

for (int i = 0; i < myArray.Length; i++)
{
    System.Console.Write($"введите элемент массива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}
System.Console.WriteLine("вывод массива: ");

for (int i = 0; i < myArray.Length; i++)
{
   System.Console.WriteLine(myArray[i]);
}