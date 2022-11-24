//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

/*
void Palindrom( int x)
{
    int tenThous = (x - (x % 10000)) / 10000;
    Console.WriteLine(tenThous);
    int thous = ((x % 10000) - (x % 1000)) / 1000;
    Console.WriteLine(thous);
    int dec = ((x % 100) - (x % 10)) / 10;
    Console.WriteLine(dec);
    int ed = x % 10;

    if (tenThous == ed && thous == dec)
    {
        Console.WriteLine($"{x} -> да");
    }
    else
    {
        Console.WriteLine($"{x} -> нет");
    }
    
}

Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());

Palindrom(n);
*/


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

/*
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

void Сube(int n)
{
    for (int i = 1; i <= n; i++)
    {        
        Console.Write($"{i * i * i}, ");
    }
}

Console.Write($"{n} -> ");
Сube(n);
*/


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


double MetodLine(double x1, double y1,double z1, double x2,  double y2,  double z2)
{
    double sum = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine($"A ({x1}, {y1}, {z1}); B  ({x2}, {y2}, {z2}) -> {sum} ");
    return sum;
    
}

Console.WriteLine("Input X1");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y1");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z1");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input X2");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Y2");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input Z2");
double z2 = Convert.ToDouble(Console.ReadLine());


MetodLine(x1, y1, z1, x2, y2, z2);