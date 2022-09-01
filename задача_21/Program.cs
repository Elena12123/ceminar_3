string GetDistanse ()
{
Console.WriteLine("Введите координату х1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z2");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Координаты точки A {x1},{y1},{z1}");
Console.WriteLine($"Координаты точки B {x2},{y2},{z2}");

double distanse = Math.Round(Math.Sqrt (Math.Pow (x2-x1,2) + Math.Pow (y2-y1,2)+ Math.Pow (z2-z1,2)),2);

return $"Расстояние между двумя точками в 3D пространстве {distanse}";
}

try
{
    Console.WriteLine(GetDistanse ());
}

catch
{
    Console.WriteLine("Введите целые числа в координаты точек");
}