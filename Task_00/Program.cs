// Напишите программу, которая принимает нп вход координаты точек X;Y  причем X != 0 и Y!=0, 
// и выдает номер четверти плоскости в которой находится точка.
Console.Clear();
//int DataEntryXY(string str)
{
    // Console.Write(str);
    //int number = int.Parse(Console.ReadLine());
    //return number;
}
//void FainQvadrat(int x, int y)
{
    //if (x > 0 && y > 0) Console.WriteLine("Это первый квадрат");
    //if (x < 0 && y < 0) Console.WriteLine("Это третий квадрат");
    //if (x < 0 && y > 0) Console.WriteLine("Это второй квадрат");
    //if (x > 0 && y < 0) Console.WriteLine("Это четвертый квадрат");
}

//int x = DataEntryXY("Введите координаты x = ");
// Console.WriteLine(x);
//int y = DataEntryXY("Введите координаты y = ");
// Console.WriteLine(y);
//FainQvadrat(x, y);

// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти

// int DataQuarter(string str)
//{
    // Console.Write(str);
    // int number = int.Parse(Console.ReadLine());
    // return number;
//}
//void PrintRange(int x)
{
    //if (x == 1) Console.WriteLine("Диапазон от х>0 до у>0");
    //if (x == 2) Console.WriteLine("Диапазон от х<0 до у>0");
    //if (x == 3) Console.WriteLine("Диапазон от х<0 до у<0");
    //if (x == 4) Console.WriteLine("Диапазон от х>0 до у<0");
}

// int x = DataQuarter("Введите номер четверти № = ");
// PrintRange(x);



// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.



//int DataEntry(string str)
{
 //   Console.Write(str);
   // int number = int.Parse(Console.ReadLine());
    //return number;
}

//double CalcDistance(int x1, int y1, int x2, int y2)
{
  //  double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    //return result;
}

//int x1 = DataEntry("Введите координаты x1 = ");
//int x2 = DataEntry("Введите координаты x2 = ");
//int y1 = DataEntry("Введите координаты y1 = ");
//int y2 = DataEntry("Введите координаты y2 = ");

//double result =Math.Round((CalcDistance( x1, y1,  x2, y2)),2);
//Console.WriteLine($"Расстояние между точками = {result}");

//Напишите программу, которая на вход принимает число (N) и выдает таблицу квадратов
// чисел от 1 до N


void TablePOW2(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    int count = 1;
    while (count<=number)
    {
        int pow = count*count;
        Console.Write(pow + " ");
        count ++;
    }
    Console.WriteLine();
}

TablePOW2("Введите число N: ");

