// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101     3  -> 11     2  -> 10

void ReversArray1(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = k;
    }
}

Console.Clear();
Console.WriteLine("Введите число N, я переведу его в двоичную систему исчислений: ");
int N1=Convert.ToInt32(Console.ReadLine());
int N2=N1;
int fig = 0;
while (N2!=0)
{
    N2=N2/2;
    fig++;
}
int[]array=new int[fig];
int I = 0;
while (N1!=0)
{
    if (N1%2==0)
    {
        array[I] = 0;
        I++;
        N1=N1/2;
    }
    else
    {
        array[I] = 1;
        I++;
        N1=N1/2;
    }
}
Console.Write("Ваше число в двоичной системе: ");
ReversArray1(array);
Console.WriteLine(String.Join(" ", array));