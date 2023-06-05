// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*
int [] Array(int size)    // Метод ввода элементов массива
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
    Console.WriteLine($"Input {i+1} number");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumPositiveElem(int[] array)  // Метод определения количества элементов массива больше 0
{
int i=0;
int sum = 0;
while (i < array.Length)
    {if(array[i]>0)
    sum = sum + 1;
    i = i + 1;
    }   
return sum;
}

Console.WriteLine("Input count of elements: ");
int count = Convert.ToInt32(Console.ReadLine());
int [] array = Array(count);
Console.Write($" Numbers more than 0: {SumPositiveElem(array)}");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void  InterPointFinder (double k1,double k2, double b1, double b2)
{
    double x=(b2-b1)/(k1-k2);
    double y= k1*x+b1;

Console.WriteLine($"The intersection point: x={x}; y={y}");
}
Console.WriteLine("Input b1 ");
int b1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1 ");
int k1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2 ");
int b2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2 ");
int k2= Convert.ToInt32(Console.ReadLine());

InterPointFinder (k1,k2,b1,b2);

