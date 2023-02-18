int[] SetArray(int n)
{
    Console.WriteLine("Введите числа:");
    int[] numbers = new int[n];
    for(int i = 0;i < n; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine()); 
    } 
    return numbers;
}

int[] PrintArr(int[] a)
{
    Console.WriteLine("Числа введённыйе пользователм: {0}",String.Join(",",a));
    return a;
}

int PosNum(int[] a)
{
    int count = 0;
    for (int i = 0; i< a.Length; i++)
    {
        if (a[i]>0)
        {
            count++;
        }
    }
    Console.WriteLine($"Кол-во числе больше нуля:{count}");
    return count;
}


Console.Write("Введите кол-во символов, которое вы будете вводить:");
int n = int.Parse(Console.ReadLine());

int[] a = SetArray(n);
int[] array = PrintArr(a);
PosNum(array);
