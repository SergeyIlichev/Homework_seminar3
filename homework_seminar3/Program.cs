/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
/*
Console.WriteLine("Введите пятизначное число ");
string number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine("Это палиндром");
    else
        Console.WriteLine("Это НЕ палиндром");
}

if (number.Length == 5)
    CheckNumber(number);
else 
Console.WriteLine($"Вы ввели не пятизначное число");

*/
/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*
int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели неверное число,введите верное число";
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int x1 = GetNumber("Введите координаты х первой точки");
int y1 = GetNumber("Введите координаты у первой точки");
int z1 = GetNumber("Введите координаты z первой точки");
int x2 = GetNumber("Введите координаты х второй точки");
int y2 = GetNumber("Введите координаты у второй точки");
int z2 = GetNumber("Введите координаты z второй точки");

double distance = Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"Расстояние между точками равно {distance}");

*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число, введите корректное число";
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void Cube(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine(Math.Pow(i,3));
    }
}

int number = GetNumber("Введите число");
Console.WriteLine();
Cube(number);

