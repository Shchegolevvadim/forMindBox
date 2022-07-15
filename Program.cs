using System.Diagnostics;

int[] GetData(int count, int a = 1)
{
    var r = new Random();
    if (a == 1)
        return Enumerable.Range(1, count).Select(e => r.Next(0, 30000)).ToArray();
    else
        return Enumerable.Range(1, count).ToArray();
}

Console.WriteLine("Введите количество параметров");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 1)
{
    Console.WriteLine("Вы вводите  радиус окружности");
    double b = Convert.ToDouble(Console.ReadLine());
    double S = Math.PI * Math.Pow(b, 2);
    Console.Write("площадь окружности равна :");
    Console.WriteLine(S);
}
if (a == 2)
{
    Console.WriteLine("Вы вводите длину прямоугольника ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Вы вводите ширину прямоугольника ");
    double d = Convert.ToDouble(Console.ReadLine());
    double S = c * d;
    Console.Write("Площадь прямоугольнка равна :");
    Console.WriteLine(S);
}
if (a == 3)
{
    Console.WriteLine("Вы вводите длины сторон треугольника, длина первой стороны:");
    double t1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Вы вводите длину второй стороны треугольника:");
    double t2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Вы вводите длину третьей стороны треугольника:");
    double t3 = Convert.ToDouble(Console.ReadLine());
    // Проверка являются ли заданные стороны сторонами треугольника:
    if ((t1 + t2) > t3 && (t2 + t3) > t1 && (t1 + t3) > t2)
    {
        Console.WriteLine("Это треугольник");
    }
    else
    {
        Console.WriteLine("Это не треугольник");
    }

    double p = (t1 + t2 + t3) / 2; // узнаем полупериметр треугольника
    double S = Math.Sqrt(p * (p - t1) * (p - t2) * (p - t3));

    Console.Write("Площадь треугольника равна: ");
    Console.WriteLine(S);
    if (
        (t1 * t1 + t2 * t2 == t3 * t3)
        || (t1 * t1 + t3 * t3 == t2 * t2)
        || (t3 * t3 + t2 * t2 == t1 * t1)
    )
    {
        Console.WriteLine("Треугольник является прямоугольным");
    }
    else
    {
        Console.WriteLine("Треугольник не является прямоугольным");
    }
}

int count = 10_000;
Stopwatch sw = new Stopwatch();
Console.WriteLine("Нахождение площади фигуры");
sw.Start();
for (int k = 0; k < 3; k++)
{
    int[] arr = GetData(count, 1);

    if (a == 3)
    {
        Console.WriteLine("Вы вводите длины сторон треугольника, длина первой стороны:");
        double t1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Вы вводите длину второй стороны треугольника:");
        double t2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Вы вводите длину третьей стороны треугольника:");
        double t3 = Convert.ToDouble(Console.ReadLine());
        double p = (t1 + t2 + t3) / 2; // узнаем полупериметр треугольника
        double S = Math.Sqrt(p * (p - t1) * (p - t2) * (p - t3));

        Console.Write("Площадь треугольника равна: ");
        Console.WriteLine(S);
    }
}
sw.Stop();
Console.WriteLine("Время выполнения задачи в миллисекундах :");
System.Console.WriteLine($"{sw.ElapsedMilliseconds}");
