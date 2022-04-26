// Функция не принимает и не возвращает
//void Print()
{
    //System.Console.WriteLine("Функция выполнена.");
}
//Print();// можно не указывать( либо повторит несколько раз если дублировать)



//Принимает и возвращает значение

//string Hello(string name)
{
//return "привет " + name;
}
//string myName = "Лосось";
//string helloName = Hello(myName);
//System.Console.WriteLine(helloName);


//принимает значение и НЕ возвращает 

//void PrintArgument(double argument)
{
    //System.Console.WriteLine(argument);
}
//PrintArgument(123.1233);



//не принимает значение и возвращает

//int Return7()
{
//return 7;
}

/*
ВозврТип Название(Параметры)
{
    Тело...
}

*/

//находит число 0 в массиве ( не по индексам а по ячейке - 5 позиция)
int PrintArrayToZero(int[] mas)
{
for (int i = 0; i < mas.Length; i++)
{
    if(mas[i]==0)
    return i;//
    System.Console.Write(mas[i] + " ");//печатает весь массив до 0
}
return -1;
}
int [] array = {1,5,7,2,8,0,1,6,2};
int zero = PrintArrayToZero(array);// возврат функцию и сохраняет 0
System.Console.WriteLine();
System.Console.WriteLine("0 находится " + zero);

//

