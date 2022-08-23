// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2        1, -7, 567, 89, 223-> 3

// Console.Clear();
// Console.WriteLine("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[size];
// int PositiveNumber = 0;
// for (int i = 0; i < size; i++)
// {   
//     Console.WriteLine($"Введите {i+1} элемент массива: ");
//     Array[i] = Convert.ToInt32(Console.ReadLine());
//     if (Array[i]>0)
//     {
//         PositiveNumber++;
//     }
// }
// Console.Write("Ваш массив: ");
// Console.WriteLine(String.Join(" ", Array));
// Console.WriteLine($"Колличество чисел больше нуля: {PositiveNumber}");





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Clear();
// Console.WriteLine("Введите число b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// if (b2-b1!=k2-k1)
// {
// double x = (b1-b2)/(k2-k1);
// double y = k1*x+b1;
// Console.WriteLine($"({x}; {y})");
// }
// else
// {
//     Console.WriteLine("Прямые не пересекаются.");
// }





// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101     3  -> 11     2  -> 10

// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = k;
//     }
// }

// Console.Clear();
// Console.WriteLine("Введите число N, я переведу его в двоичную систему исчислений: ");
// int N1=Convert.ToInt32(Console.ReadLine());
// int N2=N1;
// int fig = 0;
// while (N2!=0)
// {
//     N2=N2/2;
//     fig++;
// }
// int[]array=new int[fig];
// int I = 0;
// while (N1!=0)
// {
//     if (N1%2==0)
//     {
//         array[I] = 0;
//         I++;
//         N1=N1/2;
//     }
//     else
//     {
//         array[I] = 1;
//         I++;
//         N1=N1/2;
//     }
// }
// Console.Write("Ваше число в двоичной системе: ");
// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));





// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3         Если N = 3 -> 0 1 1         Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();
// Console.WriteLine("Сколько первых чисел Фибоначчи нужно вывести?: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N==1)
// {
//     Console.WriteLine("0");
// }
// else
// {
//     int [] fibonachi = new int[N];
//     fibonachi[0]=0;
//     fibonachi[1]=1;
//     for (int i = 2; i<N; i++)
//     {
//         fibonachi[i]=fibonachi[i-1] + fibonachi[i-2];
//     }
//     Console.WriteLine(String.Join(" ", fibonachi));
// }





// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

// Надеюсь я правильно понял, что нужно задать массив, а потом сделать его клон, скопировав каждый элемент.

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число случайно генерируемого диапазона: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите последнее число случайно генерируемого диапазона: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] MyRandomArray = CreateRandomArray(num, min, max);
Console.Write("Ваш рандомный массив:   ");
Console.WriteLine(String.Join(" ", MyRandomArray));
int[] CloneMyRandomArray = new int[num];
for (int i=0; i<num; i++)
{
    CloneMyRandomArray[i]=MyRandomArray[i];
}
Console.Write("Клон рандомного массив: ");
Console.WriteLine(String.Join(" ", CloneMyRandomArray));
