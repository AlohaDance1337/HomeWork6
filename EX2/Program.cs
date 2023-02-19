int GetValues(string massage)
{
    int a = int.Parse(Console.ReadLine());
    return a;
}

int PrintCoef(string massage, int a)
{
    Console.WriteLine($"{massage} коэффециенты введённые пользовтелем:{a}");
    return a;
}

int PrintCoord(string massage, int a)
{
    Console.WriteLine($"{massage} введённая пользовтелем:{a}");
    return a;
}

double PeresechTochek(double y1, double k1, double y2, double k2)
{
    double x = (y2 - y1)/(k1 - k2); 
    double y = k1*x + y1;
    Console.WriteLine($"Точка пересечения двух прямых ({x},{y})");
    return x;    
}

string Proverka(int y1, int k1, int y2, int k2)
{
    if ((k1==k2) && (y1 == y2))
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (y1 == y2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    return "1";
}

int a = GetValues("1");
int b = GetValues("1");
int k1 = PrintCoef("Первый (k1)", a);
int k2 = PrintCoef("Второй (k2)", b);
int c = GetValues("1");
int d = GetValues("1");
int y1 = PrintCoord("Первая координата (x1)",c);
int y2 = PrintCoord("Вторая координата (x2)",d);
Proverka(y1, k1, y2, k2);
double answer = PeresechTochek(y1, k1, y2, k2);
